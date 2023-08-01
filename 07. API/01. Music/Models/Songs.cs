using System.Text.Json.Serialization;


namespace Models;

public class Songs
{
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }


    [JsonPropertyName("song")]
    public string? Song { get; set; }


    [JsonPropertyName("genre")]
    public string? Genre { get; set; }


    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }


    public void MusicaFormatada()
    {
        Console.WriteLine($"Artist: {Artist} \n" + 
                            $"Song: {Song} \n" + 
                            $"Genre: {Genre} \n" +
                            $"Duration: {Duration / 1000}");
    }
}
