using headers.api.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) =>
{
    var headers = context.Request.Headers;

    var response = new Response
    {
        Headers = context.Request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString()),
        Message = "Available Request Headers"
    };

    return Results.Ok(response);
});

app.Run();
