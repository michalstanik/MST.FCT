using AutoMapper;
using FCT.Data.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MST.FCT.Business.Models.Geo.Country;
using MST.Flogging.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MST.FCT.API.FCTApi.Controllers
{
    /// <summary>
    /// API Controller for Countries
    /// </summary>
    [Route("api/countries/")]
    [Produces("application/json")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IGeoRepository _repository;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor for CountriesController
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public CountriesController(IGeoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Get list of all Countries
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [LogUsage("GetCountries")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CountryModel>>> GetAirports()
        {
            var airportsFromRepo = await _repository.GetAllCountriesAsync();

            return Ok(_mapper.Map<List<CountryModel>>(airportsFromRepo));
        }
        /// <summary>
        /// Get Country by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [LogUsage("GetCountry")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CountryModel>> GetAirport(int id)
        {
            var airportFromRepo = await _repository.GetCountryByIdAsync(id);

            if (airportFromRepo == null) return NotFound();

            return Ok(_mapper.Map<CountryModel>(airportFromRepo));
        }

    }
}
