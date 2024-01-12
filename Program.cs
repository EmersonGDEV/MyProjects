using ListManage;

Console.WriteLine("Seja bem vindo ao ListManage!\n");
bool menu = true;

Manager manage = new Manager();


while (menu)
{   
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("1- Deseja criar uma lista? ");
    Console.WriteLine("2- Adicionar pessoas a sua lista: ");
    Console.WriteLine("3- Verificar se uma está na lista: ");
    Console.WriteLine("4- visualisar lista: ");
    Console.WriteLine("5- remover uma pessoa da sua lista: ");
    Console.WriteLine("6- Remover todas as pessoas da sua lista: ");
    Console.WriteLine("0- Para fechar o programa:\n");
    Console.WriteLine("**********************************************");
    Console.WriteLine(" ");

    switch (Console.ReadLine())
    {
        case "1":
            manage.Create();
            break;

        case "2":
            
            manage.AdicionarPessoas();

            break;
        case "3":
            manage.verificar();

            break;

        case "4":
            
            manage.ShowList();
            break;

        case "5":
           
            manage.remove();
            break;

        case "6":
           
            manage.Apagar();
            break;


        case "0":
            Console.WriteLine("Programa encerrado");
            menu = false;
            break;

        default:
            Console.WriteLine("Opão inválida, Tente Novamente");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O progrma encerrou, Obrigado!");
