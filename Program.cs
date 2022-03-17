var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// By default uses index.html within root folder
app.UseFileServer();

//app.MapGet("/", () => "Hello Adam");

app.Run();
