using Exercice02.Abstractions;
using Exercice02.Data;
using Exercice02.Data.Repositories;
using Exercice02.Helpers;
using Exercice02.Models;
using Exercice02.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<Encryptor>();
builder.Services.AddScoped<IRepository<User>, UserRepository>();
builder.Services.AddScoped<AuthService>();

builder.Services.AddScoped<IRepository<Pizza>, PizzaRepository>();
builder.Services.AddScoped<IRepository<Ingredient>, IngredientRepository>();
builder.Services.AddScoped<PizzaService>();

builder.Services.AddHostedService<FirstRunService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

builder.AddAuthentication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();