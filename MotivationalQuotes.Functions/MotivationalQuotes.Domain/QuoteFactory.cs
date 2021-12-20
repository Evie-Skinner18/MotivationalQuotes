using System;

namespace MotivationalQuotes.Domain
{
    // aspects that vary
    // author
    // subject
    // category: e.g humourous, tear-jerker, exciting
    public class QuoteFactory
    {
    }

    public enum QuoteCategory
    {
        Humorous = 1,
        TearJerker,
        Exciting
    }
}
