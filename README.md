# Setting Up .NET API with PostgreSQL and Swagger

This guide covers the step-by-step process of setting up a **.NET API** using **PostgreSQL** with Swagger integration.

---

## 1. Create a New .NET API Project
```sh
dotnet new webapi -n PostgreSQLApi
cd PostgreSQLApi
```

## 2. Install Required NuGet Packages

Run the following commands to install necessary dependencies:

```sh
dotnet add package Microsoft.AspNetCore.OpenApi

dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet add package Swashbuckle.AspNetCore
```

## 3. Configure Database Connection
Edit `appsettings.json` and add the PostgreSQL connection string:

```json
"ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=mydb;Username=myuser;Password=mypassword"
}
```

## 4. Create the Database Context
Create a file `Models/AppDbContext.cs`:

```csharp
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Region> Regions { get; set; }
}
```

## 5. Create the Model
Create a file `Models/Region.cs`:

```csharp
public class Region
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

## 6. Register Database Context in `Program.cs`
Modify `Program.cs`:

```csharp
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
```

## 7. Generate Database Migrations
Run the following commands to create and apply migrations:

```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 8. Scaffold a Controller
Generate a RESTful controller using scaffolding:

```sh
dotnet aspnet-codegenerator controller -name RegionsController -async -api -m Region -dc AppDbContext -outDir Controllers
```

## 9. Run the API
```sh
dotnet run
```

## 10. Open Swagger UI
After running the project, open the browser and navigate to:

```
http://localhost:5000/swagger
```

or (for HTTPS):

```
https://localhost:5001/swagger
```

---

This completes the setup of a **.NET API** with **PostgreSQL** and **Swagger**!

