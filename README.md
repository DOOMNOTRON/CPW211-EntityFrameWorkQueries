# CPW211-EntityFrameWorkQueries

## Getting Started
- VS 2022
- .NET 6
- [AP Database](create_ap.sql) installed

You may need to change the DB Connection string locanted in the APContext class
By default is points to mssqllocaldb. If your AP script is not installed on mssqllocaldb, update the string.
```csharp
optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP");
```
