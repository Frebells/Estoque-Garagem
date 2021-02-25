using System;

namespace CadastroEstoque
{
    class Program
    {
        static CarroRepositorio Estoque = new CarroRepositorio();
        static void Main(string[] args)
        {
            string OpcaoUsuario = RecberOpcaoUsuario();

            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                    ListaCarros();
                    break;
                    
                    case "2":
                    //InsereCarro();
                    break;

                    case "3":
                    //AtualizaCarro();

                    case "4":
                    //ExcluiCarro();
                    break;

                    case "5":
                    //VizualizaCarro();
                    break:

                    case "6":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

                OpcaoUsuario = RecberOpcaoUsuario();
            }
        }          
        private static void ListaCarros()
        {
            Console.WriteLine("Em Estoque:");
            Console.WriteLine();

            var lista = Estoque.List();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum carro em estoque!");
            }
            foreach (var CarroRepositorio in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", Estoque.RetornaId(), Estoque.List());
                
                    
                 
            }
        }
    
        private static string RecberOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Estoque de Carros");
            Console.WriteLine("Selecione a opcao desejada:");

            Console.WriteLine("1 - Checar veiculos em estoque");
            Console.WriteLine("2 - Adicionar carro ao estoque");
            Console.WriteLine("3 - Atualizar veiculo em estoque");
            Console.WriteLine("4 - Excluir carro do estoque");
            Console.WriteLine("5 - Informacoes sobre o carro");
            Console.WriteLine("6 - Limpar a busca");
            Console.WriteLine("0 - Sair do estoque");
            Console.WriteLine();
            
            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;
        }
    }
}