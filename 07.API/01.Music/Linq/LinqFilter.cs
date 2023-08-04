using Models;


namespace Linq;

public class LinqFilter
{
    public static void FiltrarTodosGeneros(List<Songs> musicas)
    {   
        var TodosOsGeneros = musicas.Select(musica => musica.Genre).Distinct().ToList();
        
        foreach (var Genero in TodosOsGeneros)
        {
            Console.WriteLine($"- {Genero}");
        }
    }

    public static void FiltarArtistasPorGenero(List<Songs> musicas, string genre)
    {
        var TodosOsArtistas = musicas.Where(musica => musica.Genre!.Contains(genre)).Select(musica => musica.Artist).Distinct().ToList(); 
        Console.WriteLine($"Artist of genre {genre}:");
        
        foreach (var Artista in TodosOsArtistas)
        {
            Console.WriteLine($"- {Artista}");
        }
    }

    public static void FiltarMusicasPorArtista(List<Songs> musicas, string artista)
    {
        var TodasAsMusicas = musicas.Where(music => music.Artist!.Equals(artista)).Select(music => music.Song).Distinct().ToList();
        Console.WriteLine($"Músicas do artista {artista}:");
        
        foreach (var Musica in TodasAsMusicas)
        {
            Console.WriteLine($"- {Musica}");
        }
    }
}
