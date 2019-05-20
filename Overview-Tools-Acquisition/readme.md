# Overview, Tools and Acquisition (30 minutes)

> We'll get started with a quick overview of .NET Core: what it is, why you should care, and how to get set up to start using it.

## Prerequisites

### Visual Studio 2019 Preview
It’s best if you have Visual Studio 2019 16.1 Preview 3 (free Community level is fine), since there are some new desktop tooling enhancements in the recent previews. You’ll need the following workloads:
 * ASP.NET and web development
 * .NET desktop development
 * Mobile development with .NET
 * .NET Core cross-platform development
 
You can check to see what workloads you have installed by just running the installer (from the start menu, bring up Visual Studio Installer and click on Modify for Visual Studio 2019 Preview if installed).

### Visual Studio Code
* Download [Visual Studio Code](https://code.visualstudio.com) 
* Install the Live Share Extension 

### .NET Core 3.0 SDK

Install [the latest .NET Core 3.0 SDK](http://dot.net/get-core3) for your operating system.

## Overview Presentation

### Creating a new .NET Core console application using Command Line tools

1. From the command line, run `dotnet new console`
1. Type `dotnet run` to run the application. You'll see a simple "Hello World" message.

### Exploring and Editing the Application using Visual Studio Code

1. Type `code .` to launch Visual Studio Code in the current directory.
1. Take a look at the Program.cs file.
1. Change the "Hello World" message to "Hello .NET".
1. Switch to the console and type `dotnet run` to to see the update.

### Creating a new .NET Core application using Visual Studio 2019

1. Follow the steps in the [Building a complete .NET Core solution on Windows, using Visual Studio 2019](https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-on-windows-full-solution) tutorial.
    > Note: If you'd like simpler one to get started, you can first complete the [Building a C# Hello World application with .NET Core in Visual Studio 2017](https://docs.microsoft.com/en-us/dotnet/articles/csharp/getting-started/with-visual-studio) tutorial.

### Extra Credit: Create a Class Library and Xunit test solution

List available options from `dotnet new`:
```csharp
dotnet new
```
Now create a solution with a class library and a test project:
```csharp
dotnet new sln -o MyApp
cd MyApp
dotnet new classlib -o MyApp
dotnet new xunit -o MyApp.Test
dotnet sln add MyApp/MyApp.csproj
dotnet sln add MyApp.Test/MyApp.Test.csproj
cd MyApp.Test
dotnet add reference ../MyApp/MyApp.csproj
dotnet restore
dotnet build
dotnet test
```