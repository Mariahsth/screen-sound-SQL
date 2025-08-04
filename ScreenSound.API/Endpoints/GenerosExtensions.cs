using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.API.Endpoints;

public static class GenerosExtensions
{
    public static void AddEndpointsGeneros(this WebApplication app)
    {
        app.MapGet("/Generos", ([FromServices] DAL<Genero> dal) =>
        {
            var generoList = dal.Listar();
            if (generoList is null)
            {
                return Results.NotFound();
            }
            var generoListResponse = EntityListToResponseList(generoList);
            return Results.Ok(generoListResponse);
        });

        app.MapGet("/Generos/{nome}", ([FromServices] DAL<Genero> dal, string nome) =>
        {
            var genero = dal.ProcurarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
            if (genero is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(EntityToResponse(genero));

        });

        app.MapPost("/Generos", ([FromServices] DAL<Genero> dal, [FromBody] GeneroRequest generoRequest) =>
        {
            dal.Adicionar(RequestToEntity(generoRequest));
            return Results.Ok();
        });

        app.MapDelete("/Generos/{id}", ([FromServices] DAL<Genero> dal, int id) =>
        {
            var genero = dal.ProcurarPor(m => m.Id == id);
            if (genero is null)
            {
                return Results.NotFound();
            }
            dal.Deletar(genero);
            return Results.NoContent();
        });

    }

    private static Genero RequestToEntity(GeneroRequest genero)
    {
        return new Genero() { Nome = genero.Nome, Descricao = genero.Descricao };
    }

    private static ICollection<GeneroResponse> EntityListToResponseList(IEnumerable<Genero> generoList)
    {
        return generoList.Select(a => EntityToResponse(a)).ToList();
    }

    private static GeneroResponse EntityToResponse(Genero genero)
    {
        return new GeneroResponse(genero.Id, genero.Nome!, genero.Descricao!);
    }
}


