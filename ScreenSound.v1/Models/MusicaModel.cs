namespace ScreenSound.v1.Models;

public class MusicaModel
{
    public string Nome { get; }
    public BandaModel Artista { get; }
    public double Duracao { get; }
    public bool Disponivel { get; set; }

    public MusicaModel(string nome, BandaModel artista, double duracao)
    {
        Nome = nome;
        Artista = artista;
        Duracao = duracao;
    }
    
    public string DescricaoResumida
    {
        get
        {
            return $"A música {Nome}, pertence a banda {Artista.Nome}";
        }
    }
        
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("A música está disponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }

        Console.WriteLine($"Descrição: {DescricaoResumida}");
    }
}