## Option 1: Visual Studio 2017
### Creating a new Angular 2 application from the command line
1. In Visual Studio 2019, create a new ASP.NET Core 3.0 application and select the Angular template.
1. Inspect the application code.
1. Run the application in Debug mode.

## Option 2: CLI and Visual Studio Code
### Creating a new Angular application from the command line
1. Create a new ASP.NET Core application using the Angular template by executing the following command:

  ```
  dotnet new angular -o MyAngularApp
  ```
1. Change directories (`cd MyAngularApp`) into the new application directory and run `npm install`.
1. View the application code by typing `code .` to launch Visual Studio Code in the current directory.
1. Build the application using `dotnet build`

### Running the Angular application
1. From the commandline, set the ASP.NET Core development mode environment variable:

  ```
  set ASPNETCORE_ENVIRONMENT=Development
  ```
> **Note**: On OSX this is done using `export ASPNETCORE_ENVIRONMENT=Development`
  
1. Run the application using the `dotnet watch` tool:

  ```
  dotnet watch run
  ```
1. Navigate to `http://localhost:5000` to view the application.

> **Note**: Leave the application running and the browser window open for the remainder of the lab.

## Experiment with Hot Module Reloading (HMR)
1. Navigate to the Counter page in running web application.
1. In Visual Studio Code, Edit the counter implementation (`\ClientApp\app\components\counter\counter.ts`) to change the counter increment to 10:

  ``` typescript
  export class Counter {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount+=10;
    }
  }
  ```
1. Edit the Counter template (`\ClientApp\components\counter\counter.html`) to change the H2 heading text.
1. Observe that the application has refreshed with your changes. View the console output to see the debug messages printed out during the updates.

## Extra
1. Create a Knockout, React, or React + Redux application using the above steps but selecting a different project template.
1. Create a production build by setting `ASPNETCORE_ENVIRONMENT=Production`, then running the following:

  ```
  webpack --config webpack.config.vendor.js
  webpack
  ```
1. Inspect the front-end resources in browser tools and verify that the resources are minified.