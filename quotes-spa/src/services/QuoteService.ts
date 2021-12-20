import { HttpClient } from "./axios-client";
import { IQuote, QuoteCategory } from "./Quotes-dtos";

export class QuoteService {
    public async searchQuotesByCategory(category: QuoteCategory): Promise<IQuote[]> {
        const categoryNumber = category;
        const apiClient = await HttpClient.apiClient();

        let searchQuoteResponse: IQuote[] = [];
        const response = await apiClient.get<IQuote[]>(`quotes/search?category=${categoryNumber}`);

        if (response.data.length > 0) {
            searchQuoteResponse = response.data;
            console.log(searchQuoteResponse);
        }

        return searchQuoteResponse;
    }
}