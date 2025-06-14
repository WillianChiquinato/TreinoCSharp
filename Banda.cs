public class Banda
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; private set; } = string.Empty;

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        Console.WriteLine($"Álbum '{album.nomeAlbum}' adicionado à banda '{Nome}'.");
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.nomeAlbum}");
            Console.WriteLine($"Duração total: {album.duracaoTotal} segundos");
            Console.WriteLine("-------------------------");
        }
    }
}