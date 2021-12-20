using System.Collections.Generic;
using System.Net;
using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Web;
using MotivationalQuotes.Domain.Common;
using MotivationalQuotes.Domain;

namespace MotivationalQuotes.Functions
{
    public static class SearchQuotes
    {
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

            QuoteCategory category = (QuoteCategory)categoryNumber;
            var quoteFactory = new QuoteFactory(category);
            var quotesFound = new List<IQuote>() { quoteFactory.CreateQuote(category) };

            HttpResponseData response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(quotesFound);

            return response;
        }
    }
}