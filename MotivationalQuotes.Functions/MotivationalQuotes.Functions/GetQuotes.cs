using System.Collections.Generic;
using System.Net;
using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MotivationalQuotes.Functions
{
    public static class GetQuotes
    {
        [Function("GetQuotes")]
        public static async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "quotes")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("GetQuotes");
            logger.LogInformation("Les anglais mangent pour vivre; les francais vivent pour manger.");

            string responseMessage = "Hi from GetQuotes!";
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            await response.WriteStringAsync(responseMessage);

            return response;
        }
    }
}