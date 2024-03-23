namespace ScreenSound.v1.Models;

public class Album
{
    public string Nome { get; set; }

    public double DuracaoTotal => musicas.Sum(m => m.Duracao);

    private List<Musica> musicas = new List<Musica>();
    
    public void AdicionarMusica(Musica musicasParameter)
    {
        musicas.Add(musicasParameter);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"Exibindo músicas do albúm {Nome}: \n");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música --> {musica.Nome} \n");
        }

        Console.WriteLine($"Este albúm tem uma duração total de {DuracaoTotal} segundos");
    }
}