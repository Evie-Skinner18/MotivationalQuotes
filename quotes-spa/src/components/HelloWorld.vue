<template>
  <div class="hello">
    <h1>Welcome to the land of Motivational Quotes!</h1>
    <h3>Here are some exciting quotes:</h3>
    <h3 v-for="(quote, i) in excitingQuotes" :key="i">
      {{ quote.text }}
    </h3>
  </div>
</template>

<script lang="ts">
import { ref } from "@vue/runtime-core";
import { QuoteService } from "../services/QuoteService";
import { IQuote, QuoteCategory } from "@/services/Quotes-dtos";

export default {
  async setup(): Promise<unknown> {
    const quoteService = new QuoteService();
    const excitingQuotes: IQuote[] = await quoteService.searchQuotesByCategory(
      QuoteCategory.Exciting
    );

    if (excitingQuotes.length > 0) {
      return {
        excitingQuotes: ref(excitingQuotes),
      };
    }
  }
};
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
