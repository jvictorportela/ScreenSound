namespace ScreenSound.v1.Models;

public class PlayListModel
{
    private List<MusicaModel> musicas = new List<MusicaModel>();
    
    public string Nome { get; }
    public double DuracaoTotal => musicas.Sum(m => m.Duracao);
    public int QtdMusicas => musicas.Count;

    public PlayListModel(string nome)
    {
        Nome = nome;
    }
    
    public void AdicionarMusicaNaPlayList(MusicaModel musicaModelParameter)
    {
        musicas.Add(musicaModelParameter);
    }

    public void ExibirDadosDaPlayList()
    {
        Console.WriteLine($"Exibindo dados da Play List... {Nome}\n");
        Console.WriteLine($"A Play List --> {Nome}, tem {QtdMusicas} músicas e uma duração total de {DuracaoTotal} segundos. \n");
        Console.WriteLine($"As músicas contidas na Play List são:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música --> {musica.Nome}");
        }
        Console.WriteLine("\n");
    }
}