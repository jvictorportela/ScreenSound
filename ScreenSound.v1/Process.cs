using ScreenSound.v1.Models;

namespace ScreenSound.v1;

public class Process
{
    public void InitFlow()
    {
        // BandaModel banda1 = new BandaModel("Exalta Samba");
        //
        // MusicaModel musicaModelEs = new MusicaModel("Tá vendo aquela lua?", banda1, 527)
        // {
        //     Disponivel = true
        // };
        //
        // MusicaModel musicaModelEs2 = new MusicaModel("Sou o cara pra você", banda1, 324)
        // {
        //     Disponivel = false
        // };
        //
        // Album albumES = new Album("Exalta alegria");
        //
        // PlayListModel playlist1 = new PlayListModel("Pagodinho");
        // playlist1.AdicionarMusicaNaPlayList(musicaModelEs);
        // playlist1.AdicionarMusicaNaPlayList(musicaModelEs2);
        // playlist1.ExibirDadosDaPlayList();
        //
        // albumES.AdicionarMusica(musicaModelEs);
        // albumES.AdicionarMusica(musicaModelEs2);
        //
        // musicaModelEs.ExibirFichaTecnica();
        // musicaModelEs2.ExibirFichaTecnica();
        //
        // banda1.ExibirDiscografia();
        // banda1.AdicionarAlbum(albumES);
        //
        // albumES.ExibirAlbum();

        EpisodioPodCastModel ep1 = new EpisodioPodCastModel("Falando sobre política", 53, 1);
        ep1.AdicionarConvidados("João");
        ep1.AdicionarConvidados("Ariele");
        ep1.AdicionarConvidados("Lula");
        ep1.AdicionarConvidados("Bolsonaro");
        
        EpisodioPodCastModel ep2 = new EpisodioPodCastModel("Falando sobre esporte", 34, 2);
        ep2.AdicionarConvidados("Fulano");
        ep2.AdicionarConvidados("Sicrano");
        ep2.AdicionarConvidados("Bebeto");
        ep2.AdicionarConvidados("Romario");

        PodcastModel podcastModel1 = new PodcastModel("BatePapoCast", "Internet");
        podcastModel1.AdicionarEpisodio(ep1);
        podcastModel1.AdicionarEpisodio(ep2);
        podcastModel1.ExibirDetalhes();
    }
}