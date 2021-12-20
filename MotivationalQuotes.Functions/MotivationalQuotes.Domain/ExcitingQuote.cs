using MotivationalQuotes.Domain.Common;

namespace MotivationalQuotes.Domain
{
    public class ExcitingQuote : IQuote
    {
        public static ExcitingQuote Create(string author,
            string text,
            string subject)
        {
            return new ExcitingQuote(author, text, subject);
        }

        private ExcitingQuote(string author,
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
        public QuoteCategory Category => QuoteCategory.Exciting;

        public bool IsCheesy()
        {
            return Text.ToLower().Contains("love") || Text.ToLower().Contains("fun");
        }
    }
}
