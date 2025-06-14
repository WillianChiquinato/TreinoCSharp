public class PodCast
{
    private List<Episodio> episodios = new List<Episodio>();

    public string Host { get; private set; } = string.Empty;
    public string Nome { get; private set; } = string.Empty;
    public int TotalEpisodios => episodios.Count;

    public PodCast(string host, string nome)
    {
        this.Host = host;
        this.Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        foreach (var episodio in episodios.OrderBy(e => e.ordem))
        {
            Console.WriteLine($"Episódio: {episodio.resumo}");
        }
        Console.WriteLine($"\n\nTotal de Episódios: {TotalEpisodios}");
        Console.WriteLine("-------------------------");
    }
}