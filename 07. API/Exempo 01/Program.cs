using System.Text.Json;
using Arquivo.Linq;
using Arquivo.Models;

using (HttpClient client = new HttpClient()) 
{
    try
    {
        
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var songs = JsonSerializer.Deserialize<List<Musicas>>(response)!;

        LinqFilter.FiltrarTodosGeneros(songs);

        LinqOrder.OrdenarArtistas(songs);

        LinqFilter.FiltarArtistasPorGenero(songs, "pop");

        LinqFilter.FiltarMusicasPorArtista(songs, "Skrillex");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Problem found: {ex.Message}");
    }
}