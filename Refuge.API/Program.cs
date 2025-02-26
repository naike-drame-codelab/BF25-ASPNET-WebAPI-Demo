using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Refuge.API.Configurations;
using Refuge.DAL;

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

builder.Services.AddRepositories();
builder.Services.AddServices();

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
