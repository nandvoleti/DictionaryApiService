using DictionaryApp.Application.Interfaces;
using DictionaryApp.Infrastructure.Services;
using DictionaryApp.Infrastructure.Settings;

var builder = WebApplication.CreateBuilder(args);

// -----------------------------
// Bind configuration
// -----------------------------
builder.Services.Configure<DictionaryApiSettings>(
    builder.Configuration.GetSection("DictionaryApi"));

// Add services to the container.
builder.Services.AddHttpClient<IDictionaryService, DictionaryApiService>();
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition =
        System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dictionary API v1");
    });
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
