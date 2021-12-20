using System.Collections.Generic;
using System.Net;
using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Web;

namespace MotivationalQuotes.Functions
{
    public static class GetQuoteByid
    {
        [Function("GetQuoteById")]
        public static async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "quotes/id")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("GetQuoteById");
            logger.LogInformation("C# HTTP trigger function processed a request.");

            logger.LogInformation("Herro from GetQuoteById");

            var query = HttpUtility.ParseQueryString(req.Url.Query);
            string idString = query["id"];
            int id = Int32.Parse(idString);

            HttpResponseData response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString($"The quote with id {id} is 'All's well that ends well'");
            return response;
        }
    }
}