using System.Text.Json.Serialization;


namespace Arquivo.Models;

public class Musicas
{
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }


    [JsonPropertyName("song")]
    public string? Musica { get; set; }


    [JsonPropertyName("genre")]
    public string? Genero { get; set; }


    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }


    public void MusicaFormatada()
    {
        Console.WriteLine($"Artista: {Artista} \n" + 
                            $"Música: {Musica} \n" + 
                            $"Gênero: {Genero} \n" +
                            $"Duração: {Duracao / 1000}");
    }
}
