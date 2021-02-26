using System; 

namespace CadastroEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            string OpcapUser = ObterOpcaoUser();
            while (OpcapUser != "0")
            {
                switch(OpcapUser)
                {
                    
                }
            }
        }

        private static string ObterOpcaoUser()
        {
            Console.WriteLine();
            Console.WriteLine("ESTOQUE DE CARROS");
            Console.WriteLine();
            Console.WriteLine("Escolha a opcao desejada");
            Console.WriteLine("1 - Carros em estoque");
            Console.WriteLine("2 - Inserir um novo carro");
            Console.WriteLine("3 - Atualizar um carro do estoque");
            Console.WriteLine("4 - Excluir um carro do estoque");
            Console.WriteLine("5 - Exibir detalhes do carro");
            Console.WriteLine("6 - Limpar a busca");
            Console.WriteLine("0 - Sair");

            string OpcaoUser = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUser;
        }
    }
}