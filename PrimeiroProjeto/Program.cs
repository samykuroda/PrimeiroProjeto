//SCREEN SOUND

//Console.WriteLine("Bem vindo ao Screen Sound!");

string mensagemBoasVindas = "Boas Vindas ao Screen Sound!";
List<string> listaDeBandas = new List<string>();

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
            Console.WriteLine(listaDeBandas);
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 0:
            Console.WriteLine("Bye bye :)");
            break;
        default:
            Console.WriteLine("Opção inválida, xuxu!!!");
            break;
    }
}

void RegistrarUmaBanda()
{
    Console.Clear();
    Console.WriteLine("********************");
    Console.WriteLine("REGRISTRO DE BANDAS");
    Console.WriteLine("********************");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();