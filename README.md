# C# Everywhere with Blazor #
This repository includes slides and a sample application for Dave's *C# Everywhere with Blazor* conference talk.

If you have any comments, questions, or suggestions, feel free to submit a pull request!

# 'Image Of The Day' application

This application uses the NASA [Astronomy Picture of the Day (APOD) API](https://api.nasa.gov/api.html#apod). To call this API, you need to get a key from NASA. If you plan to use 
this extensively, please [apply for your own key](https://api.nasa.gov/index.html#apply-for-an-api-key).

Much love to the inimitable David Pine ([@IEvangelist](https://github.com/IEvangelist)) for the demo inspiration.

## Getting started with Blazor ##
This application targets Blazor 0.6.0. If you've never worked with Blazor, make sure you have the following prerequisites before moving forward.
* [.NET Core 2.1 SDK](https://go.microsoft.com/fwlink/?linkid=873092), *2.1.402 or later*
* [Visual Studio 2017](https://go.microsoft.com/fwlink/?linkid=873092), *15.8 or later with the ASP.NET and web development workload*
* Install the [Blazor Language Services](https://marketplace.visualstudio.com/items?itemName=aspnet.blazor) extension from the Visual Studio Marketplace
* Install the Blazor templates from the command line:

    ```
    dotnet new -i Microsoft.AspNetCore.Blazor.Templates
    ```

