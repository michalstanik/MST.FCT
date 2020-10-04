using AutoMapper;
using MST.FCT.Business.Models.Aviation.Airport;
using FCT.Data.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper)) ;
        }

        /// <summary>
        /// Get a list of all Airports
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<AirportModel>>> GetAirports()
        {
            var airportsFromRepo = await _repository.GetAllAirportsAsync();

            return Ok(_mapper.Map<List<AirportModel>>(airportsFromRepo));
        }
    }
}
