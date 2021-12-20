using MotivationalQuotes.Domain.Common;
using System;
using System.Collections.Generic;

namespace MotivationalQuotes.Domain
{
    public class QuoteFactory
    {
        public QuoteFactory(QuoteCategory quoteCategory)
        {
            _quoteCategory = quoteCategory;
        }

        private readonly QuoteCategory _quoteCategory;

        public IQuote CreateQuote(QuoteCategory quoteCategory)
        {
            switch (quoteCategory)
            {
                case QuoteCategory.Humorous: return HumorousQuote.Create("Rowan Atkinson", "WIBBLE", "Blackadder goes Forth");
                case QuoteCategory.TearJerker: return TearJerkerQuote.Create("Édith Piaf", "Il pleut, il pleut, il pleut", "Heartbreak", 10, false);
                case QuoteCategory.Exciting: return ExcitingQuote.Create("Lady Gaga", "I want your stupid love!", "Fun times with Gaga");
                default: return ExcitingQuote.Create("No author", "No quote", "No quote found");
            }
        }
    }
}
