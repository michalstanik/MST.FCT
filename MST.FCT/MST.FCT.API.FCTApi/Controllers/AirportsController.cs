﻿using AutoMapper;
using FCT.Data.Domain.Aviation;
using FCT.Data.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MST.Core.Helpers.Attributes;
using MST.FCT.Business.Models.Aviation.Airport;
using MST.FCT.Business.Services.RequestHeaders;
using MST.Flogging.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MST.FCT.API.FCTApi.Controllers
{
    /// <summary>
    /// API Controller for Airports
    /// </summary>
    [Route("api/airports/")]
    [Produces("application/json")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        private readonly IAviationRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// AirportsController Constructor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
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
        [Produces(AirportRequestHeaders.Airport)]
        [RequestHeaderMatchesMediaType("Accept",
            "application/json",
            AirportRequestHeaders.Airport)]
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
        [HttpGet("{id}", Name = "GetAirport")]
        [LogUsage("GetAirport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(AirportRequestHeaders.Airport)]
        [RequestHeaderMatchesMediaType("Accept",
            "application/json",
            AirportRequestHeaders.Airport)]
        public async Task<ActionResult<AirportModel>> GetAirport(int id)
        {
            return await GetSpecificAirport<AirportModel>(id);
        }

        /// <summary>
        /// Get an Airport based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [LogUsage("GetAirportWithFlights")]
        [Produces(AirportRequestHeaders.AirportWithFlights)]
        [RequestHeaderMatchesMediaType("Accept", AirportRequestHeaders.AirportWithFlights)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult<AirportWithFlightsModel>> GetAirportWithFlights(int id)
        {
            return await GetSpecificAirport<AirportWithFlightsModel>(id,true);
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
        /// <summary>
        /// Delete the airport
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAirport(int id)
        {
            if (id == 0) return BadRequest();

            var airportToDelete = await _repository.GetAiportByIdAsync(id);

            if (airportToDelete == null) return NotFound();

            await _repository.DeleteAirportAsync(airportToDelete.Id);

            return NoContent();
        }

        private async Task<ActionResult<T>> GetSpecificAirport<T>(int airportId, bool includeFlights = false) where T : class
        {
            var airportFromRepo = await _repository.GetAiportByIdAsync(airportId, includeFlights);

            if (airportFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<T>(airportFromRepo));
        }
    }
}
