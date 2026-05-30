using ServiceContracts;
using Services;
using ServiceContracts.Options;
using RepositoryContracts;
using Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.Configure<WikiRateOptions>(
    builder.Configuration.GetSection("WikiRate"));


builder.Services.AddHttpClient<IWikiRateAnswerService, WikiRateClient>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["WikiRate:BaseUrl"]!);
});

builder.Services.AddScoped<IMaterialsService, MaterialsService>();
builder.Services.AddScoped<IMaterialsRepository, MaterialsRepository>();
builder.Services.AddSingleton<IAuthService, InMemoryAuthService>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
