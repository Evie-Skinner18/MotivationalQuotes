export interface IQuote {
  author: string;
  text: string;
  subject: string;
  category: string;
  isCheesy: boolean;
}

export enum QuoteCategory {
  Humorous = 1,
  TearJerker,
  Exciting,
}
