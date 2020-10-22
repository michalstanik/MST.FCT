using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using MST.FCT.Business.Models.Aviation.Airport;
using MST.FCT.Business.Services.RequestHeaders;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;

namespace MST.FCT.API.FCTApi.OperationFilters
{
    /// <summary>
    /// 
    /// </summary>
    public class AirportsOperationFilters : IOperationFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var mediaTypesGetAirportDictionary = new Dictionary<string, Type>()
            {
                {AirportRequestHeaders.AirportWithFlights , typeof(AirportWithFlightsModel) }
            };

            switch (operation.OperationId)
            {
                case "GetAirport":

                    foreach (var mediaType in mediaTypesGetAirportDictionary)
                    {
                        //operation.Responses[StatusCodes.Status200OK.ToString()].Content.Add(
                        //    mediaType.Key,
                        //    new OpenApiMediaType()
                        //    {
                        //        Schema = context.SchemaGenerator.GenerateSchema(   SchemaRegistry.GetOrRegister(mediaType.Value)
                        //    });
                    }
                    break;

                default:
                    return;
            }
        }
    }
}
