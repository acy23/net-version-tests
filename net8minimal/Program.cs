using net8minimal.Models;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var basePath = AppContext.BaseDirectory;
var filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, "data.json");

app.MapGet("/provinces", () =>
{
    try
    {
        string jsonData = File.ReadAllText(filePath);

        var provinces = JsonSerializer.Deserialize<List<Province>>(jsonData, options: new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return Results.Json(provinces);
    }
    catch (Exception ex)
    {
        return Results.Problem($"An error occurred: {ex.Message}");
    }
});

app.Run();