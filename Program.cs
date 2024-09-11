using Dapper;
using ListManage.Models;
using Microsoft.Data.SqlClient;


namespace ListManage
{
    class Program
    {

        static void Main(string[] args)
        {
            const string connectionString = @"Server=localhost,1433;Database=ListManage;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
            //var manage = new Manager();
            Console.WriteLine("Seja bem vindo ao ListManage!\n");
            bool menu = true;

            while (menu)
            {

                Console.WriteLine("**********************************************");
                // //     Console.WriteLine("1- Deseja criar uma lista? ");
                Console.WriteLine("2- Adicionar pessoas a sua lista: ");
                // //     Console.WriteLine("3- Verificar se uma está na lista: ");
                Console.WriteLine("4- Visualizar lista: ");
                Console.WriteLine("5- Editar um convidado de sua lista: ");
                // //     Console.WriteLine("6- Remover todas as pessoas da sua lista: ");
                Console.WriteLine("0- Para fechar o programa:\n");
                // //     Console.WriteLine("**********************************************");
                // //     Console.WriteLine(" ");

            using (var connection = new SqlConnection(connectionString))
            {
                switch (Console.ReadLine())
                {
                    
                    case "2":
                            Manager.Criacao(connection);
                        break;

                    case "4":
                          Manager.Listagem(connection);
                    break;

                    case"5":
                        Manager.EditList(connection);
                    break;

                    case "0":
                        Console.WriteLine("Programa encerrado");
                        menu = false;
                        break;

                        // //         default:
                        // //             Console.WriteLine("Opção inválida, Tente Novamente");
                        // //             break;
                }
            }

                // //     Console.WriteLine("Pressione uma tecla para continuar");
                // //     Console.ReadLine();

            }

            Console.WriteLine("O programa encerrou, Obrigado!");
        }

        static void SelectList(SqlConnection connection)
        {

        }
    }

}

