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
        private readonly IStatsRepository _statsRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor for UserController
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="statsRepository"></param>
        /// <param name="mapper"></param>
        public UsersController(IUserRepository repository, IStatsRepository statsRepository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _statsRepository = statsRepository ?? throw new ArgumentNullException(nameof(statsRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Get User by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetUser")]
        [LogUsage("GetUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(UserRequestHeaders.User)]
        [RequestHeaderMatchesMediaType("Accept",
            "application/json",
            UserRequestHeaders.User)]
        public async Task<ActionResult<UserModel>> GetUser(string id)
        {
            var userFromRepo = await _repository.GetUserByIdAsync(id);

            if (userFromRepo == null) return NotFound();

            return Ok(_mapper.Map<UserModel>(userFromRepo));
        }

        /// <summary>
        /// Get User by id with Stats
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [LogUsage("GetUserWithStats")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(UserRequestHeaders.UserWithStats)]
        [RequestHeaderMatchesMediaType("Accept", UserRequestHeaders.UserWithStats)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult<UserWithStatsModel>> GetUsersWithStats(string id)
        {
            var userFromRepo = await _repository.GetUserByIdAsync(id);

            if (userFromRepo == null) return NotFound();

            var userWithStats = _mapper.Map<UserWithStatsModel>(userFromRepo);

            userWithStats.UserStats.UserFlightsCount = _statsRepository.GetFlightsCountForUser(id);
            userWithStats.UserStats.FlightsDistance = _statsRepository.GetFlightsDistanceForUser(id);
            userWithStats.UserStats.FlightsTime = _statsRepository.GetFlightsTimeForUser(id);
            userWithStats.UserStats.FlightsTime = _statsRepository.GetFlightsTimeForUser(id);
            userWithStats.UserStats.AirportsCount = _statsRepository.GetAirportsCountForUser(id);
            userWithStats.UserStats.AirportsCountryCount = _statsRepository.GetAirportsCountryCountForUser(id);

            return Ok(userWithStats);
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
