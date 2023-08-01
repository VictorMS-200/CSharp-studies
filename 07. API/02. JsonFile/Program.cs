using System.Text.Json;
using Models;



using (HttpClient client = new HttpClient()) 
{
    try
    {
        // Get the response as a string.
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var songs = JsonSerializer.Deserialize<List<Songs>>(response)!;

        var FavoriteSongsOfVictor = new FavoritesSongs("Victor");

        FavoriteSongsOfVictor.AddSong(songs[6]);
        FavoriteSongsOfVictor.AddSong(songs[541]);
        FavoriteSongsOfVictor.AddSong(songs[465]);
        FavoriteSongsOfVictor.AddSong(songs[888]);
        FavoriteSongsOfVictor.AddSong(songs[691]);  

        FavoriteSongsOfVictor.JsonMusics();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Problem found: {ex.Message}");
    }
}