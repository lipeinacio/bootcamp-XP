using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudApi.Data;
using CrudApi.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Estudantes
{
    public static class EstudantesEndpoints
    {
        public static void AddEndpointsEstudantes(this WebApplication app)
        {
            // Para criar se usa o Post
            app.MapPost("estudantes", async (AddEstudantesRequest request, AppDBContext context, CancellationToken ct) => 
            {
                var jaExiste = await context.Estudantes.AnyAsync(estudante => estudante.Nome == request.Nome, ct);

                    if (jaExiste)
                    {
                        return Results.Conflict("Ja Existe!");
                    }
                    
                var novoEstudante = new Estudante(request.Nome);
                await context.Estudantes.AddAsync(novoEstudante, ct);
                await context.SaveChangesAsync(ct);

                var estudanteRetorno = new EstudanteDto(novoEstudante.Id, novoEstudante.Nome);

                return Results.Ok(estudanteRetorno);
            });            

            // Retomar Todos os Estudantes Cadastrados
            app.MapGet("estudantes", async (AppDBContext context, CancellationToken ct) => 
            
            {
                var estudantes = await context
                    .Estudantes
                    .Where(estudante => estudante.Ativo)
                    .Select(estudante => new EstudanteDto(estudante.Id, estudante.Nome))
                    .ToListAsync(ct);

                return estudantes;
            });

            // Atualizar Nome Estudantes
            app.MapPut("estudantes/ {id:guid}", async (Guid id, UpdateEstudantesRequest request, AppDBContext context, CancellationToken ct) => 
            {
                var estudante = await context.Estudantes.SingleOrDefaultAsync(e => e.Id == id, ct);

                if (estudante == null)
                    return Results.NotFound();

                estudante.AtualizarNome(request.Nome);
                await context.SaveChangesAsync(ct);
                return Results.Ok(new EstudanteDto(estudante.Id, estudante.Nome));
            });

            // Deletar
            app.MapDelete("estudantes/ {id:guid}", async (Guid id, AppDBContext context, CancellationToken ct) =>
            {
                var estudante = await context.Estudantes.SingleOrDefaultAsync(estudante => estudante.Id == id, ct);

                if(estudante == null)
                    return Results.NotFound();

                    estudante.Desativar();
                    await context.SaveChangesAsync(ct);
                    return Results.Ok();
            });

        }
    }
}