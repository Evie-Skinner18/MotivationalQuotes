using System.Collections.Generic;
using System.Net;
using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Web;
using MotivationalQuotes.Domain;

namespace MotivationalQuotes.Functions
{
    public static class SearchQuotes
    {
        // search by author, subject or category
        [Function("SearchQuotes")]
        public static async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "quotes/search")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("SearchQuotes");
            logger.LogInformation("Searching for quotes...");

            var query = HttpUtility.ParseQueryString(req.Url.Query);
            string author = query["author"];
            string subject = query["subject"];
            string categoryString = query["category"];

            int categoryNumber = Int32.Parse(categoryString);

            // parse category as enum value
            QuoteCategory category = (QuoteCategory)categoryNumber;

            HttpResponseData response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            response.WriteString($"This quote belongs to the {category} category");

            return response;
        }
    }
}