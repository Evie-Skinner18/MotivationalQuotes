using MotivationalQuotes.Domain.Common;

namespace MotivationalQuotes.Domain
{
    public class TearJerkerQuote : IQuote
    {
        public static TearJerkerQuote Create(string author,
            string text,
            string subject,
            int numberOfTearsJerked,
            bool happyTears)
        {
            return new TearJerkerQuote(author, text, subject, numberOfTearsJerked, happyTears);
        }

        private TearJerkerQuote(string author,
            string text,
            string subject,
            int numberOfTearsJerked,
            bool happyTears)
        {
            Author = author;
            Text = text;
            Subject = subject;
            NumberOfTearsJerked = numberOfTearsJerked;
            HappyTears = happyTears;
        }

        public string Author { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        public QuoteCategory Category => QuoteCategory.TearJerker;
        public int NumberOfTearsJerked { get; set; }
        public bool HappyTears { get; set; }

        public bool IsCheesy()
        {
            return NumberOfTearsJerked < 3 && HappyTears;
        }
    }
}
