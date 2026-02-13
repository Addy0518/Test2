using Microsoft.EntityFrameworkCore;
using Test2.Interface;
using Test2.Models;
using Test2.Repositry;
using Test2.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<JobContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IOfficeRepositry,OfficeRepositry>();
builder.Services.AddScoped<IOfficeService, OfficeService>();

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
