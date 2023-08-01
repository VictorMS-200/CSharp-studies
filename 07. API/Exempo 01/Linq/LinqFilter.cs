using Arquivo.Models;


namespace Arquivo.Linq;

public class LinqFilter
{
    public static void FiltrarTodosGeneros(List<Musicas> musicas)
    {   
        var TodosOsGeneros = musicas.Select(musica => musica.Genero).Distinct().ToList();
        
        foreach (var Genero in TodosOsGeneros)
        {
            Console.WriteLine($"- {Genero}");
        }
    }

    public static void FiltarArtistasPorGenero(List<Musicas> musicas, string genero)
    {
        var TodosOsArtistas = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList(); 
        Console.WriteLine($"Artistas do gênero {genero}:");
        
        foreach (var Artista in TodosOsArtistas)
        {
            Console.WriteLine($"- {Artista}");
        }
    }

    public static void FiltarMusicasPorArtista(List<Musicas> musicas, string artista)
    {
        var TodasAsMusicas = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Musica).Distinct().ToList();
        Console.WriteLine($"Músicas do artista {artista}:");
        
        foreach (var Musica in TodasAsMusicas)
        {
            Console.WriteLine($"- {Musica}");
        }
    }
}
