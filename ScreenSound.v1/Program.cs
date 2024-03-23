using ScreenSound.v1.Models;

Album albumMpb = new Album();
albumMpb.Nome = "Djavan";

Musica musica1 = new Musica();
musica1.Nome = "Oceano";
musica1.Duracao = 213;
Musica musica2 = new Musica();
musica2.Nome = "Meu amor";
musica2.Duracao = 314;

albumMpb.AdicionarMusica(musica1);
albumMpb.AdicionarMusica(musica2);

albumMpb.ExibirAlbum();
