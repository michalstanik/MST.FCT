using AutoMapper;
using FCT.Data.Domain.User;
using FCT.Data.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MST.Core.Helpers.Attributes;
using MST.FCT.Business.Models.User.User;
using MST.FCT.Business.Services.RequestHeaders;
using MST.Flogging.Core.Attributes;
using System;
using System.Threading.Tasks;

namespace MST.FCT.API.FCTApi.Controllers
{
    /// <summary>
    /// API Controller for Users
    /// </summary>
    [Route("api/users/")]
    [Produces("application/json")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor for UserController
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public UsersController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Get User by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [LogUsage("GetUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(UserRequestHeaders.User)]
        [RequestHeaderMatchesMediaType("Accept",
            "application/json",
            UserRequestHeaders.User)]
        public async Task<ActionResult<UserModel>> GetUser(string id)
        {
            var airportFromRepo = await _repository.GetUserByIdAsync(id);

            if (airportFromRepo == null) return NotFound();

            return Ok(_mapper.Map<UserModel>(airportFromRepo));
        }

        /// <summary>
        /// Creat new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody] UserForCreationModel user)
        {
            if (user == null)
                return BadRequest();

            if (user.Id == string.Empty)
            {
                ModelState.AddModelError("ID", "The Id shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdUser = await _repository.AddUserAsync(_mapper.Map<TUser>(user));

            return Created("users", _mapper.Map<UserForCreationModel>(createdUser));
        }
    }
}
