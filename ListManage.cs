

namespace ListManage
{
    public class Manager 
    {
        private List<string> ListPessoa = new List<string>();

        public void Create()
        {
            Console.Clear();
            Console.WriteLine("Lista Criada!!");
        }

        public void AdicionarPessoas()
        {
            Console.Clear();
            Console.WriteLine($"Adicione pessoas na sua lista,");
            Console.WriteLine($"Digite o nome: \n");
            string? nomeConvidado = Console.ReadLine();
            ListPessoa.Add(nomeConvidado);

            Console.WriteLine($"{nomeConvidado} Foi Adicionado a lista! ");
        }

        public void ShowList()
        {
            Console.Clear();
            if (ListPessoa.Any())
            {
                Console.WriteLine("Sua Lista: \n");
                foreach (var nomes in ListPessoa)
                {
                    Console.WriteLine(nomes);
                }
            }
            else
            {
                Console.WriteLine(" A Lista está vazia ");
            }

        }

        public void remove()
        {
            Console.Clear();
            Console.WriteLine("Quem você deseja remover? ");
            string? remover = Console.ReadLine();
            ListPessoa.Remove(remover);
            Console.WriteLine("\n ");
            Console.WriteLine($"{remover} Foi removido com sucesso! ");
        }

        public void Apagar()
        {
            Console.Clear();
            Console.WriteLine("Tem certeza que deseja apagar todos os nomes da lista ? \n");
            Console.WriteLine("digite '1' para sim e '2' para não:");
            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == 1)
            {
                ListPessoa.Clear();
            }

            Console.WriteLine("Todos os membros da lista foram apagados.");

            
        }

        public void verificar()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome para verificar se ela está ou não na lista\n");
            string? procurar = Console.ReadLine();

            if(ListPessoa.Contains(procurar))
            {
                Console.WriteLine($"{procurar} Está na lista!!"); 
            }
            else
            {
                Console.WriteLine($"{procurar} Não está na Lista.");
            }


        }
    }
}
