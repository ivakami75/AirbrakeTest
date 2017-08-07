using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace AspAirbrake.Endpoints
{
    public class InfoController
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public InfoController(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("/info")]
        public async Task<string> GetInfo()
        {
            //var request = httpContextAccessor.HttpContext.Request;
            //StringValues header;
            //if (request.Headers.TryGetValue(ApiServerConstants.ADS_HEADER_INFO_REGION, out header))
            //{
            //    logger.LogDebug($"DOS rest service GET INFO from region {header[0]}");
            //}
            //else
            //{
            //    logger.LogDebug("DOS rest service GET INFO");
            //}

            return await Task.FromResult("Info Controller").ConfigureAwait(false);
        }

        [HttpGet("/ping")]
        public IActionResult Ping()
        {
            return new OkResult();
        }
    }
}
