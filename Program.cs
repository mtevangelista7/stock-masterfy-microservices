using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using StockMasterfyAPI.Models;
using StockMasterfyAPI.Services;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

DefaultTypeMap.MatchNamesWithUnderscores = true;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => { });
app.MapControllers();

app.Run();
