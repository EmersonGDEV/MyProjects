
using System.Data;
using System.Data.Common;
using Dapper;
using ListManage.Models;
using Microsoft.Data.SqlClient;

namespace ListManage
{
    public class Manager
    {
        public static void Listagem(SqlConnection connection)
        {
            var convidado = connection.Query<Convidados>("SELECT [Id],[Nome],[Cpf],[Vip] FROM Convidados");
                foreach (var item in convidado)
                {
                    Console.WriteLine($"{item.Id} - {item.Nome} - {item.Cpf} - {item.Vip}");
                }
        }

        public static void Criacao(SqlConnection connection)
        {
            Console.WriteLine("Digite o nome do convidado");
            string nomeConvidado = Console.ReadLine();

            Console.WriteLine($"Digite o Cpf de {nomeConvidado}");
            string cpfConvidado = Console.ReadLine();

            Console.WriteLine($"O {nomeConvidado} é Vip?");
            string vipConvidado = Console.ReadLine();

            var convidados = new Convidados();

            convidados.Nome = nomeConvidado;
            convidados.Cpf = cpfConvidado;
            convidados.Vip = vipConvidado;

            var insertSql = "INSERT INTO [Convidados] VALUES(@Nome, @Cpf, @Vip)";

            var rows = connection.Execute(insertSql, new
                {
                    convidados.Id,
                    convidados.Nome,
                    convidados.Cpf,
                    convidados.Vip,
                });
                    Console.WriteLine($"{rows} linhas inseridas");
        }

        public static void EditList(SqlConnection  connection)
        {
            Console.Clear();
            Console.WriteLine("digite o número de identificação da lista(ID):");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o nome do convidado(a): ");
            string editNome = Console.ReadLine();
            Console.WriteLine("Digite o novo cpf: ");
            string editCpf = Console.ReadLine();
            Console.WriteLine("A pessoa é vip?");
            string editVip = Console.ReadLine();


            var updateQuery = "Update [Convidados] SET [Nome] = @nome, [Cpf] = @cpf, [Vip] = @vip WHERE [Id] = @id";
            var rows = connection.Execute(updateQuery, new{
                Id = id,
                Nome = editNome,
                Cpf = editCpf,
                Vip = editVip
            });

            Console.WriteLine($"{rows} registros atualizados");
        }

        public static void Deletar(SqlConnection  connection)
        {
               
        }
    }
}
