namespace Arquivo.Models;

public class MusicasPeferidas
{
    public string? Nome { get; set; }
    public List<Musicas> ListaDeMusicas { get; }

    public MusicasPeferidas(string Nome)
    {
        this.Nome = Nome;
        ListaDeMusicas = new List<Musicas>();
    }

    public void AdicionarMusica(Musicas musica)
    {
        ListaDeMusicas.Add(musica);
    }

    public void RemoverMusica(Musicas musica)
    {
        ListaDeMusicas.Remove(musica);
    }

    public void ExibirMusicas()
    {
        foreach (var musica in ListaDeMusicas)
        {
            Console.WriteLine($"{musica}");
        }
    }
}
