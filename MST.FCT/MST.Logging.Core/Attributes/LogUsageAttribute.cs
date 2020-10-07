﻿using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using System;

namespace MST.Flogging.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogUsageAttribute : ResultFilterAttribute
    {
        private readonly string _usageName;

        /// <summary>
        /// Logs usage of the decorated action method
        /// </summary>
        /// <param name="usageName"></param>
        public LogUsageAttribute(string usageName)
        {
            _usageName = usageName;
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Log.Information("Usage captured for {UsageName}", _usageName);
        }
    }
}
