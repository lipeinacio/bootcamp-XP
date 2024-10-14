using DesafioMinimalAPI.Dominio.Interfaces;
using DesafioMinimalAPI.Dominio.Sevicos;
using Dominio.Entidades;
using Infraestrutura.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IIAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("mysql"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql")));
});


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", ([FromBody] Dominio.DTOs.LoginDTO loginDTO, IIAdministradorServico administradorServico) =>
{
    if(administradorServico.Login(loginDTO) != null)
        return Results.Ok("Login com Sucesso!");
    
    else
        return Results.Unauthorized();

}) ;

app.Run();
