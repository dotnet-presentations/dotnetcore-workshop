# Overview, Tools and Acquisition (1 hour)

> We'll get started with a quick overview of .NET Core: what it is, why you should care, and how to get set up to start using it.

## Prerequisites
* [Visual Studio 2017 (Latest Public Preview)](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15)
* [.NET Core SDK (2.0.0-preview2)](https://github.com/dotnet/cli#installers-and-binaries)

## Overview Presentation

### Creating a new .NET Core console application using Command Line tools

1. From the command line, run `dotnet new console`
1. Type `dotnet run` to run the application. You'll see a simple "Hello World" message.

### Exploring and Editing the Application using Visual Studio Code

1. Type `code .` to launch Visual Studio Code in the current directory.
1. Take a look at the Program.cs file.
1. Change the "Hello World" message to "Hello Build".
1. Switch to the console and type `dotnet run` to to see the update.

### Creating a new .NET Core application using Visual Studio 2017

1. Follow the steps in the [Building a complete .NET Core solution on Windows, using Visual Studio 2017](https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-on-windows-full-solution) tutorial.
    > Note: If you'd like simpler one to get started, you can first complete the [Building a C# Hello World application with .NET Core in Visual Studio 2017](https://docs.microsoft.com/en-us/dotnet/articles/csharp/getting-started/with-visual-studio) tutorial.

### Extra Credit: Create a Class Library and Xunit test solution
```
dotnet new (lists options)
dotnet new sln -o MyApp
cd MyApp
dotnet new classlib -o MyApp
dotnet new xunit -o MyApp.Test
dotnet sln add MyApp/MyApp.csproj
dotnet sln add MyApp.Test/MyApp.Test.csproj
cd MyApp.Test
dotnet add Reference ../MyApp/MyApp.csproj
dotnet restore
dotnet build
dotnet test
```
