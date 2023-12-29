using Dapper.Contrib.Extensions;
using StockMasterfyAPI.Data;
using static StockMasterfyAPI.Data.UsuarioContext;

public static class UsuariosEndpoints
{
    public static void MapUsuariosEndpoints(this WebApplication app)
    {
        app.MapGet("/", () => "Mini Tarefas API");

        app.MapGet("/usuarios", async (GetConnection connectionGetter) =>
        {
            using var con = await connectionGetter();
            return con.GetAll<Usuario>().ToList();
        });

        app.MapGet("/usuario/{id}", async (GetConnection connectionGetter, int id) =>
        {
            using var con = await connectionGetter();
            return con.Get<Usuario>(id);
        });

        app.MapPost("/usuario", async (GetConnection connectionGetter, Usuario usuario) =>
        {
            using var con = await connectionGetter();
            var id = con.Insert(usuario);
            return Results.Created($"/usuario/{id}", usuario);
        });
    }
}