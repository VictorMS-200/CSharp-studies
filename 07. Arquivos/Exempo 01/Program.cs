using System.Text.Json;
using Arquivo.Linq;
using Arquivo.Models;

using (HttpClient client = new HttpClient()) 
{
    try
    {
        
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); // Converte a resposta get em uma string

        var musicas = JsonSerializer.Deserialize<List<Musicas>>(resposta)!; // Serializa a string em uma lista de objetos

        // Filtra todos os generos musicais
        //LinqFilter.FiltrarTodosGeneros(musicas);

        // Ordena os artistas
        //LinqOrder.OrdenarArtistas(musicas);

        // Filtra os artistas por genero
        //LinqFilter.FiltarArtistasPorGenero(musicas, "pop");

        // Filtra as musicas pelo artista
        LinqFilter.FiltarMusicasPorArtista(musicas, "Skrillex");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um erro {ex.Message}");
    }
}