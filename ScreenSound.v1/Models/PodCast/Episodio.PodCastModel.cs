namespace ScreenSound.v1.Models;

public class EpisodioPodCastModel
{
    private List<string> convidados = new List<string>();
    public double Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"Episódio de número {Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    public string Titulo { get; }
    
    public EpisodioPodCastModel(string titulo, double duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}