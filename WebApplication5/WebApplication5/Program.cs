var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name : "Defualt",
    pattern : "{controller=Home}/{action=Index}/{id?}"
    );


//app.MapGet("/", () => "Hello World!");

app.Run();