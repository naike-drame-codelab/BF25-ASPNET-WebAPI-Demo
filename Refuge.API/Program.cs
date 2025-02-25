using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Refuge.BLL.Enums;
using Refuge.BLL.Interfaces.Repositories;
using Refuge.BLL.Interfaces.Services;
using Refuge.BLL.Services;
using Refuge.DAL;
using Refuge.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// sérialiser les enums en string
builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RefugeContext>(
    b => b.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

builder.Services.AddScoped<ICatService, CatService>();
builder.Services.AddScoped<ICatRepository, CatRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
