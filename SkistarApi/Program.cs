using Microsoft.EntityFrameworkCore;
using SkistarApi.Data;
using SkistarApi.Repositories;
using SkistarApi.Repositories.Interface;
using SkistarApi.Services;
using SkistarApi.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("Production")),
    ServiceLifetime.Scoped
   );

builder.Services.AddScoped<ISkierService, SkierService>();
builder.Services.AddScoped<ISkierRepository, SkierRepository>();

builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
