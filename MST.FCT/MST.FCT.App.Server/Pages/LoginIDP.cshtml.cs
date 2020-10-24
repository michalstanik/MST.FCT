using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MST.Core.Helpers.Services;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Pages
{
    public class LoginIDPModel : PageModel
    {
        private readonly IUserInfoService _userInfoService;

        public LoginIDPModel(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }
        public async Task OnGetAsync(string redirectUri)
        {
            if (string.IsNullOrWhiteSpace(redirectUri))
            {
                redirectUri = Url.Content("~/");
            }

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                Response.Redirect(redirectUri);
            }

            await HttpContext.ChallengeAsync(
               OpenIdConnectDefaults.AuthenticationScheme,
               new AuthenticationProperties { RedirectUri = redirectUri });
        }
    }
}
