using System.Text.Json;
using Linq;
using Models;



using (HttpClient client = new HttpClient()) 
{
    try
    {
        // Get the response as a string.
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // Convert the string to object.
        var songs = JsonSerializer.Deserialize<List<Songs>>(response)!;
        
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