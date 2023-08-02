using System.Text.Json.Serialization;


namespace Models;

public class Songs
{
    // Creating a list of keys to format the key
    private string[] keys = {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};

    // Creating properties
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }


    [JsonPropertyName("song")]
    public string? Song { get; set; }


    [JsonPropertyName("genre")]
    public string? Genre { get; set; }


    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }


    [JsonPropertyName("key")]
    public int Key { get; set; }

    // Creating a method to format the key
    public string KeyFormatted()
    {
        return keys[Key];
    }


    public void SongFormatted()
    {
        Console.WriteLine($"Artist: {Artist} \n" + 
                            $"Song: {Song} \n" + 
                            $"Genre: {Genre} \n" +
                            $"Duration: {Duration / 1000} \n" +
                            $"Key: {KeyFormatted()}");
    }
}
