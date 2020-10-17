using AutoMapper;
using MST.FCT.Business.Models.Aviation.Airport;
using FCT.Data.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MST.Flogging.Core.Attributes;
using FCT.Data.Domain.Aviation;

namespace MST.FCT.API.FCTApi.Controllers
{
    [Route("api/airports/")]
    [Produces("application/json")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        private readonly IAviationRepository _repository;
        private readonly IMapper _mapper;

        public AirportsController(IAviationRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Get a list of all Airports
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [LogUsage("GetAirports")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<AirportModel>>> GetAirports()
        {
            var airportsFromRepo = await _repository.GetAllAirportsAsync();

            return Ok(_mapper.Map<List<AirportModel>>(airportsFromRepo));
        }

        /// <summary>
        /// Get an Airport based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [LogUsage("GetAirport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<AirportModel>> GetAirport(int id)
        {
            var airportFromRepo = await _repository.GetAiportByIdAsync(id);

            if (airportFromRepo == null) return NotFound();

            return Ok(_mapper.Map<AirportModel>(airportFromRepo));
        }

        /// <summary>
        /// Create new Airport
        /// </summary>
        /// <param name="airport"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CreateAirport([FromBody] AirportForCreationModel airport)
        {
            if (airport == null)
                return BadRequest();

            if (airport.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdAirport = await _repository.AddAirportAsync(_mapper.Map<Airport>(airport));

            return Created("airports", createdAirport);
        }
    }
}
