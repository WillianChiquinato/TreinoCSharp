Console.Clear();
Banda banda = new Banda("Csharp Band");

Album album = new Album("Csharp para testes");

Musica musica1 = new Musica("Csharp", banda, 2023, 200, true);
Musica musica2 = new Musica("Csharp 2", banda, 2025, 250, false);

album.AddMusica(musica1);
album.AddMusica(musica2);

Console.WriteLine("\n\n");
album.ExibirMusicasDoAlbum();

banda.AdicionarAlbum(album);
banda.ExibirDiscografia();

Console.WriteLine("Pressione qualquer tecla para sair...");

//Para o desafio do curso02.
Episodio episodio = new Episodio("Tecnologia C#", 3600, 1);
episodio.AdicionarConvidados("João");
episodio.AdicionarConvidados("Maria");

Episodio episodio2 = new Episodio("Desenvolvimento de Software", 5400, 2);
episodio2.AdicionarConvidados("Carlos");
episodio2.AdicionarConvidados("José");

PodCast podCast = new PodCast("Tech Host", "Tech Podcast");
podCast.AdicionarEpisodio(episodio);
podCast.AdicionarEpisodio(episodio2);
podCast.ExibirDetalhes();
