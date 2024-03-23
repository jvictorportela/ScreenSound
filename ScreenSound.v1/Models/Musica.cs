namespace ScreenSound.v1.Models;

public class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public double Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida
    {
        get
        {
            return $"A música {Nome}, pertence a banda {Artista}";
        }
    }
        
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("A música está disponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }

        Console.WriteLine($"Nome completo: {DescricaoResumida}");
    }
}