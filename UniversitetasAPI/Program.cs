using System.Data;
using Npgsql;
using Dapper;
using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Repositories;
using UniversitetasAPI.Services;
using DbUp;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
string dbConnectionString = builder.Configuration.GetConnectionString("PostgreConnection");

//EnsureDatabase.For.PostgresqlDatabase(dbConnectionString);
//var upgrader =
//       DeployChanges.To
//           .PostgresqlDatabase(dbConnectionString)
//           .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
//           .LogToConsole() //i console prisijungia ir matai, kaip ten susikuria tavo paduoti scriptai
//           .Build();
//var result = upgrader.PerformUpgrade();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDepartamentasRepository, DepartamentasRepository>();
builder.Services.AddTransient<IDepartamentasService, DepartamentasService>();
builder.Services.AddTransient<IPaskaitaRepository, PaskaitaRepository>();
builder.Services.AddTransient<IPaskaitaService, PaskaitaService>();
builder.Services.AddTransient<IStudentasRepository, StudentasRepository>();
builder.Services.AddTransient<IStudentasService,  StudentasService>();


builder.Services.AddTransient<IDbConnection>((sp) => new NpgsqlConnection(dbConnectionString));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
