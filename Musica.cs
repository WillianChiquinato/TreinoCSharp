public class Musica
{
    public string Nome { get; set; }
    public Banda Artista { get; private set; }
    public int AnoLancamento { get; set; }
    public int Duracao { get; set; }
    public bool DisponivelPlano { get; set; }
    //Propriedade somente leitura para resumo geralmente usa ArrowFunction ou lambda.
    public string DescricaoResumo =>
        $"A Musica {Nome} feita pelo artista {Artista} foi lançada em ({AnoLancamento})";

    public Musica(string nome, Banda artista, int anoLancamento, int duracao, bool disponivelPlano)
    {
        this.Nome = nome;
        this.Artista = artista;
        this.AnoLancamento = anoLancamento;
        this.Duracao = duracao;
        this.DisponivelPlano = disponivelPlano;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (DisponivelPlano)
        {
            Console.WriteLine("Disponível no Plano, aproveite!!");
        }
        else
        {
            Console.WriteLine("Não esta disponível no Plano, aduira um plano maior!!");
        }
    }
}