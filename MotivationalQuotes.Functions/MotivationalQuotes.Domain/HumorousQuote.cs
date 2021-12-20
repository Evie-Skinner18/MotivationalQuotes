using MotivationalQuotes.Domain.Common;
using System.Collections.Generic;
using System.Linq;

namespace MotivationalQuotes.Domain
{
    public class HumorousQuote : IQuote
    {
        public static HumorousQuote Create(string author,
            string text,
            string subject)
        {
            return new HumorousQuote(author, text, subject);
        }

        private HumorousQuote(string author,
            string text,
            string subject)
        {
            Author = author;
            Text = text;
            Subject = subject;
        }

        public string Author { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        public QuoteCategory Category => QuoteCategory.Humorous;
        private List<string> HumorousTerms => new List<string>() { "smelly", "fatty", "wallop", "wibble" };

        public bool IsCheesy()
        {
            return HumorousTerms.Any(h => Text.ToLower().Contains(h));
        }
    }
}
