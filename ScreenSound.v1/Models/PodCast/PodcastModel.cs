namespace ScreenSound.v1.Models;

public class PodcastModel
{
    private List<EpisodioPodCastModel> episodiosPodCastModels = new List<EpisodioPodCastModel>();
    
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodiosPodCastModels.Count;

    public PodcastModel(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(EpisodioPodCastModel ep)
    {
        episodiosPodCastModels.Add(ep);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O Podcast {Nome}, usa o Host {Host} e tem um total de {TotalEpisodios} episódios \n");
        Console.WriteLine($"Episódios do Podcast:");
        foreach (var ep in episodiosPodCastModels.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Detalhes do Ep --> {ep.Resumo}");
        }
    }
}