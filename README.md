# C# Everywhere with Blazor #
This repository includes slides and a sample application for my *C# Everywhere with Blazor* conference talk.

If you have any comments, questions, or suggestions, feel free to submit a pull request!

## 'Image Of The Day' application ##

This application uses the NASA [Astronomy Picture of the Day (APOD) API](https://api.nasa.gov/api.html#apod). To call this API, you need to get a key from NASA. If you plan to use 
this extensively, please [apply for your own key](https://api.nasa.gov/index.html#apply-for-an-api-key).

Thanks to David Pine ([@IEvangelist](https://github.com/IEvangelist)) for the demo inspiration.

## Getting started with Blazor ##
This application targets Blazor 0.8.0. If you've never worked with Blazor, make sure you have the following prerequisites before moving forward.
* [.NET Core 3.0 Preview 2 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.0), *3.0.100-preview-010184*
* [Visual Studio 2019](https://visualstudio.com/preview), *Preview 2 or later with the ASP.NET and web development workload*
* Install the [Blazor Language Services](https://go.microsoft.com/fwlink/?linkid=870389) extension from the Visual Studio Marketplace
* Install the Blazor templates from the command line:

    ```
    dotnet new -i Microsoft.AspNetCore.Blazor.Templates::0.8.0-preview-19104-04
    ```

