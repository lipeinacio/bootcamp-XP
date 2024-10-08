var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (Dominio.DTOs.LoginDTO loginDTO) =>
{
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
        return Results.Ok("Login com Sucesso!");
    
    else
        return Results.Unauthorized();

}) ;

app.Run();
