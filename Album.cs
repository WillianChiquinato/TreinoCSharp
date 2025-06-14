public class Album
{
    private List<Musica> Musicas = new List<Musica>();
    public string nomeAlbum { get; set; } = string.Empty;
    public int duracaoTotal => Musicas.Sum(m => m.Duracao);

    public Album(string nomeAlbum)
    {
        this.nomeAlbum = nomeAlbum;
    }

    public void AddMusica(Musica musica)
    {
        Musicas.Add(musica);
        Console.WriteLine($"Música '{musica.Nome}' adicionada ao álbum '{nomeAlbum}'.");
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Álbum: {nomeAlbum}");
        Console.WriteLine("Músicas no álbum:");
        foreach (var musica in Musicas)
        {
            musica.ExibirDetalhes();
            Console.WriteLine("\n-------------------------\n");
        }
        Console.WriteLine($"Duração total do álbum: {duracaoTotal} segundos");
    }
}