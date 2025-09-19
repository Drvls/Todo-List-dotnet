using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TodoList.Db;
using TodoList.Interfaces;
using TodoList.Repositories;
using TodoList.Services;

var builder =  WebApplication.CreateBuilder(args);

var connectionAddress = builder.Configuration.GetConnectionString("mysql");
builder.Services.AddDbContext<DbContexto>(options => 
    options.UseMySql(connectionAddress, ServerVersion.AutoDetect(connectionAddress)));

builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
builder.Services.AddScoped<ITarefaService, TarefaService>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

// Passar para programação async