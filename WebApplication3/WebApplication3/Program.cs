var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page....Get");
    });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page.... Post");
    });

    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page.... Put");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page....Delete");
    });
});

app.Run(async (HttpContext context)=>
{
    await context.Response.WriteAsync("Hello World!....");
});

//app.MapGet("/", () => "Hello World!");

//app.Map("/Home", () => "Hello World! Map");

//app.MapPut("/Home", () => "Hello World! MapPut");
//app.MapGet("/Home", () => "Hello World! MapGet");
//app.MapPost("/Home", () => "Hello World! MapPost");
//app.MapDelete("/Home", () => "Hello World! MapDelete");



app.Run();
