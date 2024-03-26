namespace ScreenSound.v1.Models;

public class BandaModel
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; }

    public BandaModel(string nome)
    {
        Nome = nome;
    }
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        foreach (var album in albuns)
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            Console.WriteLine($"A banda {Nome}, tem o álbum {album.Nome} || e a duração total do " +
                              $"álbum é de {album.DuracaoTotal} segundos.");
        }
    }
}