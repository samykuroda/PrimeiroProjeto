//SCREEN SOUND

//Console.WriteLine("Bem vindo ao Screen Sound!");

string mensagemBoasVindas = "Boas Vindas ao Screen Sound!";
//List<string> listaDeBandas = new List<string>() { "U2", "Pink Floyd", "Calypso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 6 });
bandasRegistradas.Add("The Beatles", new List<int> { 10, 4, 8 });
void ExibirBoasVindas ()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemBoasVindas);
}
;

void ExibirMenuDeOpcoes ()
{
    ExibirBoasVindas();
    Console.WriteLine("\nESCOLHA A OPCAO DESEJADA: ");
    Console.WriteLine(@"
1- Registrar uma Banda
2- Mostrar todas as Bandas
3- Avaliar uma Banda
4- Exbir a média de uma Banda
0- Sair");
    Console.Write("\n Digite sua opção: ");
    int opcaoEscolhida =  int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarUmaBanda();
            break;
        case 2:
            ExibirTodasAsBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 0:
            Console.WriteLine("Bye bye :)");
            break;
        default:
            Console.WriteLine("Opção inválida, xuxu!!!");
            ExibirMenuDeOpcoes();
            break;
    }
}

void RegistrarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("REGISTRO DA OPÇÃO");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

void ExibirTodasAsBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("EXIBINDO TODAS AS BANDAS");

    //for (int i = 0; i < listaDeBandas.Count; i = i + 1) //i++ soma +1 no i
    //{
    //    Console.WriteLine($"Banda {i+1}: {listaDeBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.Write("Digite qualquer tecla para voltar ao menu. ");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuDeOpcoes();

}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeCaracteres = titulo.Length;
    string asteriscos = "".PadLeft(quantidadeDeCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("AVALIAR UMA BANDA");

    //Digitar a banda que deseja avaliar
    Console.Write("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!;

    //Conferir se a banda existe no dicionário.
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Digite a nota: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota}, para a banda {nomeDaBanda}, foi atribuida com sucesso.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenuDeOpcoes();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine($"Digite uma tecla para voltar ao menu...");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuDeOpcoes();
    }
}
ExibirMenuDeOpcoes();