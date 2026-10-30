//SCREEN SOUND

//Console.WriteLine("Bem vindo ao Screen Sound!");

string mensagemBoasVindas = "Boas Vindas ao Screen Sound!";

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
    int opcaoEscolhida =  int.Parse(Console.ReadLine());

    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
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

ExibirMenuDeOpcoes();