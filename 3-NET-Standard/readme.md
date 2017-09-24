# Maximize Code Reuse With .NET Standard (1 hour)

> .NET everywhere! In this fun session, we'll explain exactly what .NET Standard is, then show how .NET Standard allows us to write the one .NET class and use it in the full .NET Framework, .NET Core, Xamarin, UWP, and more.

## 1. Moving library code to a .NET Standard library
> Note: You can jump to the complete state for demo 1 and 2 by switching to the `result` branch.
1. Clone [https://github.com/jongalloway/netstandard-dataset-demo](https://github.com/jongalloway/netstandard-dataset-demo)
1. Run the application and show that it's using an XML backed DataSet in a Windows Forms application. This application shows all Northwind employees that are now at retirement age.
1. Right-click the solution and add a .NET Standard Class Library to the solution.
1. Delete `Class1.cs` from the new .NET Standard project.
1. Drag the `NorthwindDb.cs` class and the `northwind.xml` file from the original project into the new .NET Standard project.
1. Add a project reference from the original project to the .NET Standard project.
1. Delete the `NorthwindDb.cs` class and the `northwind.xml` file from the original project.
1. Run the application and verify it still works.

## 2. Referencing an old NuGet package from a .NET Standard library
1. Add a reference to the `NQuery` package from the .NET Standard library.
1. Modify the `GetData()` method to use the `NQuery` library as shown below:
   ```csharp
        public static string GetData()
        {
            var result = "";
            var dataSet = new DataSet();
            dataSet.ReadXml(@"C:\demos\northwind.xml");

            var dataContext = new DataContext();
            dataContext.AddTablesAndRelations(dataSet);

            var sql = @"
                SELECT  e.FirstName + ' ' + e.LastName
                FROM    Employees e
                WHERE   e.Birthdate.AddYears(65) < GETDATE()
            ";

            var query = new Query(sql, dataContext);
            var results = query.ExecuteDataTable();
            var values = results.Rows.Cast<DataRow>().Select(r => (string)r[0]);
            result = string.Join(Environment.NewLine, values);

            return result;
        }
   ```
1. Run the application and demonstrate that the reference to the NuGet package is working due to the .NET Standard compatability shim.

## 3. Targeting platform specific features from a .NET Standard library
1. Clone the [https://github.com/terrajobst/netstandard-gps-demo](https://github.com/terrajobst/netstandard-gps-demo) repository.
1. Note that there are two different applications (Windows Forms and UWP) backed by two different GPS libraries that do essentially the same thing. These libraries don't share code because the different platforms have different geolocation APIs.
1. Run the Windows Forms application and show that it's using the geolocation API.
   > Note: If you're going to run the UWP application, you'll need to publish it locally first.
1. Switch to the `result` branch for this repository (either by toggling in Visual Studio or using `git checkout result` from the command line).
1. Note that these two applications are now sharing one .NET Standard library using [C# preprocessor directives](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-if).
1. Explain that this library can also now add an `IsSupported()` method which uses the same preprocessor logic to return true or false depending on whether GPS support is available. This allows you to share the .NET Standard library to any platform, and clients can check if geolocation is supported before making the library call.
1. In the project properties, turn on NuGet package generation support. Build the application and show that just one NuGet package is created. Previously, you'd need to write your own script to build a single NuGet targeting multiple platforms.

> Note: You can see these demos in this [.NET Standard Deep Dive](https://channel9.msdn.com/Shows/On-NET/NET-Standard-Deep-Dive) video on Channel 9. 