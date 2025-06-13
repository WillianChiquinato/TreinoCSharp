int opcaoNumerica = -1;

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>()
{
    { "Metallica", new List<int>() { 2, 4, 10} },
    { "Iron Maiden", new List<int>() { 10} },
    { "AC/DC", new List<int>() { 10} },
    { "Nirvana", new List<int>() { 10} },
    { "Pink Floyd", new List<int>() { 8}},
    { "Led Zeppelin", new List<int>() { 2, 4, 10 } },
    { "The Rolling Stones", new List<int>() { 10}},
    { "Queen", new List<int>() { 7}},
    { "The Beatles", new List<int>() },
    { "Guns N' Roses", new List<int>() }
};

void ExibirLogo()
{
    Console.WriteLine(@"


░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nEscolha uma opção: ");
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Listar todas as bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir média da banda");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscreva dua opção: ");
    string opcao = Console.ReadLine()!;
    opcaoNumerica = int.Parse(opcao);

    switch (opcaoNumerica)
    {
        case 1:
            Console.WriteLine("Você escolheu registrar uma banda.");
            Thread.Sleep(1000);
            RegistrarBanda();
            break;
        case 2:
            Console.WriteLine("Você escolheu listar todas as bandas.");
            Thread.Sleep(1000);
            MostrarBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu avaliar uma banda.");
            Thread.Sleep(1000);
            AvaliacoesDasBandas();
            break;
        case 4:
            Console.WriteLine("Você escolheu exibir a média da banda.");
            Thread.Sleep(1000);
            MediaDasBandas();
            break;
        case 0:
            Console.WriteLine("Você escolheu sair do programa.");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

void RegistrarBanda()
{
    string nomeBanda;

    Console.Clear();
    Console.WriteLine("Registrar uma nova banda");
    Console.Write("Digite o nome da banda: ");
    nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda, new List<int>());

    Console.WriteLine($"A banda {nomeBanda} foi reistrada com sucesso!!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("Bandas registradas:");

    if (bandas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda registrada.");
    }
    else
    {
        int i = 1;
        foreach (var banda in bandas.Keys)
        {
            Console.WriteLine($"{i} - {banda}");
            i++;
        }
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    ExibirMenu();
}

void AvaliacoesDasBandas()
{
    Console.Clear();
    Console.WriteLine("Avaliar uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        Console.Write("Digite a nota (0 a 10): ");
        int nota = int.Parse(Console.ReadLine()!);
        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida. Deve ser entre 0 e 10.");
            Thread.Sleep(1000);
            AvaliacoesDasBandas();
            return;
        }

        bandas[nomeBanda].Add(nota);
        Console.WriteLine($"Avaliação de {nota} registrada para a banda {nomeBanda}.");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"Banda {nomeBanda} não encontrada.");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenu();
    }
}

void MediaDasBandas()
{
    Console.Clear();
    Console.WriteLine("Média das avaliações de uma banda");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandas.ContainsKey(nomeBanda))
    {
        List<int> avaliacoes = bandas[nomeBanda];
        if (avaliacoes.Count == 0)
        {
            Console.WriteLine($"A banda {nomeBanda} não possui avaliações.");
        }
        else
        {
            double media = avaliacoes.Average();
            Console.WriteLine($"A média das avaliações da banda {nomeBanda} é: {media:F2}");
        }
    }
    else
    {
        Console.WriteLine($"Banda {nomeBanda} não encontrada.");
    }

    Console.WriteLine("\nEscreva qualquer coisa para voltar ao menu.");
    Console.WriteLine("Digite -1 se quiser ver a media de outra banda.");
    int input = int.Parse(Console.ReadLine()!);

    if (input == -1)
    {
        MediaDasBandas();
    }
    else
    {
        ExibirMenu();
    }
}
ExibirMenu();