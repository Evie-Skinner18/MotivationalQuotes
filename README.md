# Motivational Quotes
A Vue 3 and C#.Net 6 Azure Functions app showing motivational quotes!

# Architecture
Motivational Quotes uses a Vue single page application to display a motivational quote to the user at the click of a button. It does so by consuming an Azure functions API, via an intermediary 'provider' class written in TypeScript.

# In a Future Iteration I Would...
- Use more of .Net 6's new features
- Implement the factory pattern in a more sophisticated way
- Add a data access layer and store the motivational quotes resources in Azure blob storage or Cosmos DB
- Make the front end app more stylish and attractive
- Add unit tests for the domain logic
- Implement Azure AD authentication for the front end app, using msal.
- Try to use more of Vue 3's composition API... Even though I don't personally like it 😆

# Tools, Technologies and Concepts Used
- C# .Net 6
- Azure functions
- Vue 3
- TypeScript
- Webpack
- Domain Driven Design
- Factory pattern (in C#)
- Lady Gaga :heart:

# How to Run the App
- Install .Net 6
- Install the .Net CLI
- Install the Azure Functions Core Tools
- Install Node.js
- Create a file called '.env' in quotes-spa. Fill it with the following:
    - `VUE_APP_API_BASE_URL=`[base url of the Azure Functions API for you locally]
- Run the following commands from MotivationalQuotes.Functions/MotivationalQuotes.Functions
    - `dotnet restore`
    - `dotnet build`
    - `func start --csharp`
- Run the following commands from quotes-spa
    - `npm i`
    - `npm run serve`
