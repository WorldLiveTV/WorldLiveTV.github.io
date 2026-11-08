using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseHttpsRedirection();


app.UseStaticFiles(new StaticFileOptions
{
    var = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath)),
    RequestPath = ""
});

app.MapGet("/", () => Results.File(Path.Combine(builder.Environment.ContentRootPath, "index.html"), "text/html"));

app.Run();

