## Creating a new Angular 2 application
1. From a commandline, create and navigate to a new empty directory.
1. Create a new Angular 2 application using the "aspnetcore-spa" scaffolder:

  ```
  yo aspnetcore-spa
  ```
1. View the application code by typing `code .` to launch Visual Studio Code in the current directory.
1. Restore packages using `dotnet restore`
1. Build the application using `dotnet build`

## Running the Angular 2 application
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
1. In Visual Studio Code, Edit the counter implementation ((\ClientApp\app\components\counter\counter.ts) to change the counter increment to 10:

  ``` typescript
  export class Counter {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount+=10;
    }
  }
  ```
1. Edit the Counter template (\ClientApp\components\counter\counter.html) to change the H2 heading text.
1. Observe that the application has refreshed with your changes. View the console output to see the debug messages printed out during the updates.

## Extra
1. Create an Aurelia, Knockout, React, or React + Redux application using the above steps but selecting a different option in the Yeoman scaffolder.
1. Create a production build by setting `ASPNETCORE_ENVIRONMENT=Production`, then running the following:

  ```
  webpack --config webpack.config.vendor.js
  webpack
  ```
Then inspect the front-end resources in browser tools and verify that the resources are minified.