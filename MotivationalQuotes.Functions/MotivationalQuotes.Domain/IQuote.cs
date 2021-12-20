using MotivationalQuotes.Domain.Common;

namespace MotivationalQuotes.Domain
{
    public interface IQuote
    {
        string Author { get; set; }
        public string Text { get; set; }
        string Subject { get; set; }
        QuoteCategory Category { get; }

        bool IsCheesy();
    }
}
