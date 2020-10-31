using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using MST.FCT.Business.Models.User.User;
using MST.FCT.Business.Services.RequestHeaders;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;

namespace MST.FCT.API.FCTApi.OperationFilters
{
    /// <summary>
    /// Operation filters for Users
    /// </summary>
    public class UsersOperationFilters : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            var mediaTypesGetAirportDictionary = new Dictionary<string, Type>()
            {
                {UserRequestHeaders.UserWithStats , typeof(UserWithStatsModel) }
            };

            switch (operation.OperationId)
            {
                case "GetUser":

                    foreach (var mediaType in mediaTypesGetAirportDictionary)
                    {
                        operation.Responses[StatusCodes.Status200OK.ToString()].Content.Add(
                            mediaType.Key,
                            new OpenApiMediaType()
                            {
                                Schema = context.SchemaGenerator.GenerateSchema(mediaType.Value, context.SchemaRepository)
                            });
                    }
                    break;

                default:
                    return;
            }
        }
    }
}
