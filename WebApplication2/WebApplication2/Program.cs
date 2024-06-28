var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//    name : "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}"
//    ); 

app.MapControllers();


//app.MapGet("/", () => "Hello World!");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welcome to my first Application App1");
//});


//app.Use(async (context,next) =>
//{
//    await context.Response.WriteAsync("Welcome to my first Application App1 \n");
//    await next(context);
//});

//app.Use(async (context,next) =>
//{
//    await context.Response.WriteAsync("Welcome to my first Application App2 \n");
//    await next(context);
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welcome to my first Application App3");
//});

app.Run();
