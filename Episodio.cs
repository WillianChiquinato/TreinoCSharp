public class Episodio
{
    private List<string> convidados = new List<string>();
    public int duracao { get; private set; }
    public int ordem { get; private set; }
    public string resumo => $"Episodio {ordem} - {titulo} com duração de {duracao} segundos -- {string.Join(", ", convidados)}";
    public string titulo { get; private set; } = string.Empty;

    public Episodio(string titulo, int duracao, int ordem)
    {
        this.titulo = titulo;
        this.duracao = duracao;
        this.ordem = ordem;
    }

    public void AdicionarConvidados(string nomeConvidade)
    {
        convidados.Add(nomeConvidade);
    }
}