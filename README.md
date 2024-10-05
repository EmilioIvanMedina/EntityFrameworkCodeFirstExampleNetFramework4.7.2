# EntityFrameworkCodeFirstExampleNetFramework4.7.2
 Example of an MVC Project with an ORM EF code first, create a Database (local database, included in VS solution)


Since this Visual Studio solution and its projects are using .NET Framework 4.x libraries, here we are working with Entity Framework 6 (EF6). Therefore, we need to use the Package Manager console in visual studio to run the Entity Framework commands: 
```Enable-Migrations
Add-Migration InitialCreate
Update-Database```