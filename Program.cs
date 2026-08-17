using BookStoreAPI.Data;
using DotNetEnv;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//load Env data
Env.Load();
var connectionString = Environment.GetEnvironmentVariable("DATABASE");

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//DbContext

builder.Services.AddDbContext<Database>(
    options => options.UseSqlServer(
        connectionString
        )
    );

//repositories here DI
//builder.Services.AddScoped<IAuthor, AuthorRepository>();

//OData setup
builder.Services
    .AddControllers()
    .AddOData(
    options => options.Select().Filter().OrderBy().Count()
    //.Expand().SetMaxTop()
    );



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
