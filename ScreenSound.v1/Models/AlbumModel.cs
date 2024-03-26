namespace ScreenSound.v1.Models;

public class Album
{
    private List<MusicaModel> musicas = new List<MusicaModel>();
    public string Nome { get; set; }
    public double DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nome)
    {
        Nome = nome;
    }
    
    public void AdicionarMusica(MusicaModel musicaModelParameter)
    {
        musicas.Add(musicaModelParameter);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"Exibindo músicas do álbum {Nome}: \n");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música --> {musica.Nome} \n");
        }

        Console.WriteLine($"Este albúm tem uma duração total de {DuracaoTotal} segundos");
    }
}