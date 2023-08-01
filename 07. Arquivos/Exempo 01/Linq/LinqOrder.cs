using Arquivo.Models;


namespace Arquivo.Linq;

public class LinqOrder
{
    public static void OrdenarArtistas(List<Musicas> musicas)
    {
        var ordenacao = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        
        foreach (var artista in ordenacao)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}