<template>
  <div class="hello">
    <h1>Welcome to the land of Motivational Quotes</h1>
    <button v-for="(category, i) in quoteCategories" 
      :key="i"
      @click="getQuotes(i)">
      Click for {{ category }} quote
    </button>
    <h3 v-for="(quote, i) in quotes" :key="i">
      {{ quote.Text }}
      - {{ quote.Author }}
    </h3>
  </div>
</template>

<script lang="ts">
import { Vue } from "vue-class-component";
import { QuoteService } from "../services/QuoteService";
import { IQuote, QuoteCategory } from "@/services/Quotes-dtos";

export default class HelloWorld extends Vue {
  quotes: IQuote[] = [];
  quoteService = new QuoteService();
  quoteCategories: string[] = [
    QuoteCategory[QuoteCategory.Humorous],
    QuoteCategory[QuoteCategory.TearJerker],
    QuoteCategory[QuoteCategory.Exciting]
  ];

  async getQuotes(categoryIndex: number): Promise<void> {
    const categoryNumber = categoryIndex + 1;

    const quotes: IQuote[] =
      await this.quoteService.searchQuotesByCategory(categoryNumber);

    this.quotes = quotes.length > 0 ? quotes : [];
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
