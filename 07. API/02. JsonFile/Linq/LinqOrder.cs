using Models;


namespace Linq;

public class LinqOrder
{
    public static void OrdenarArtistas(List<Songs> musicas)
    {
        var ordenacao = musicas.OrderBy(musica => musica.Artist).Select(musica => musica.Artist).Distinct().ToList();
        
        foreach (var artista in ordenacao)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}