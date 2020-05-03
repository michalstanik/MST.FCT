using IdentityModel;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using MST.IDP.Configuration.Interfaces;
using MST.IDP.Domain;
using MST.IDP.Services.EmailService;
using MST.IDP.UserService.Services;
using System;
using System.Threading.Tasks;

namespace MST.IDP.Controllers.UserRegistration
{
    public class UserRegistrationController : Controller
    {
        private readonly ILocalUserService _localUserService;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IConfiguration _configuration;
        private readonly IRootConfiguration _rootConfiguration;
        private readonly IEmailService _emailService;

        public UserRegistrationController(
            ILocalUserService localUserService,
            IIdentityServerInteractionService interaction,
            IConfiguration configuration,
            IRootConfiguration rootConfiguration,
            IEmailService emailService,
            IWebHostEnvironment environment
            )
        {
            _localUserService = localUserService ??
                throw new ArgumentNullException(nameof(localUserService));
            _interaction = interaction ??
                throw new ArgumentNullException(nameof(interaction));
            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));
            _rootConfiguration = rootConfiguration ??
                throw new ArgumentNullException(nameof(rootConfiguration));
            _emailService = emailService ??
                throw new ArgumentNullException(nameof(emailService));
            Environment = environment ??
                throw new ArgumentNullException(nameof(environment));
        }

        public IWebHostEnvironment Environment { get; }

        [HttpGet]
        public async Task<IActionResult> ActivateUser(string securityCode)
        {
            if (await _localUserService.ActivateUser(securityCode))
            {
                ViewData["Message"] = "Your account was successfully activated.  " +
                    "Navigate to your client application to log in.";
            }
            else
            {
                ViewData["Message"] = "Your account couldn't be activated, " +
                    "please contact your administrator.";
            }

            await _localUserService.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public IActionResult RegisterUser(string returnUrl)
        {
            var vm = new RegisterUserViewModel()
            { ReturnUrl = returnUrl };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userToCreate = new User
            {
                Username = model.UserName,
                Subject = Guid.NewGuid().ToString(),
                Email = model.Email,
                Active = false
            };

            userToCreate.Claims.Add(new UserClaim()
            {
                Type = "country",
                Value = model.Country
            });

            userToCreate.Claims.Add(new UserClaim()
            {
                Type = JwtClaimTypes.Address,
                Value = model.Address
            });

            userToCreate.Claims.Add(new UserClaim()
            {
                Type = JwtClaimTypes.GivenName,
                Value = model.GivenName
            });

            userToCreate.Claims.Add(new UserClaim()
            {
                Type = JwtClaimTypes.FamilyName,
                Value = model.FamilyName
            });

            _localUserService.AddUser(userToCreate, model.Password);
            await _localUserService.SaveChangesAsync();

            // create an activation link
            var link = Url.ActionLink("ActivateUser", "UserRegistration",
                new { securityCode = userToCreate.SecurityCode });

            if (_rootConfiguration.EmailConfiguration.Active == false)
            {
                if (Environment.IsDevelopment())
                {
                    Console.WriteLine(link);
                }
            }
            else
            {
                if (Environment.IsDevelopment())
                {
                    Console.WriteLine("Sending email with link: " + link);
                    Console.WriteLine("Sending Email from: " + _rootConfiguration.EmailConfiguration.Email);
                }
                //TODO: Sendong via batter formated html tempalte
                await _emailService.SendEmail(model.Email,
                    "Yourr activation link for FCT portal",
                    "Your activation link: " + link);
            }

            return View("ActivationCodeSent");
        }
    }
}
