using System;
using System.Collections.Generic;

namespace CadastroEstoque
{
    class Program
    {
        static CarroRepositorio Estoque = new CarroRepositorio();
        static void Main(string[] args)
        {
            string OpcaoUsuario = ReceberOpcaoUsuario();

            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                    ListaCarros();
                    break;
                    
                    case "2":
                    InsereCarro();
                    break;

                    case "3":
                    //AtualizaCarro();
                    break;

                    case "4":
                    //ExcluiCarro();
                    break;

                    case "5":
                    //VizualizaCarro();
                    break;

                    case "6":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

                OpcaoUsuario = ReceberOpcaoUsuario();
            }
            Console.WriteLine("Opcao invalida, tente novamente: ");
            Console.ReadLine();
        }          
        private static void ListaCarros()
        {
            Console.WriteLine("Em Estoque:");
            Console.WriteLine();

            var lista = Estoque.Lista();    

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum carro em estoque!");
                return;
            }
            foreach (var Carro in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", Carro.retornaId(), Carro.retornaMarca());                  
            }
        }

        private static void InsereCarro()
        {
            Console.WriteLine("Adicionando Carro em estoque");
            foreach (int i in Enum.GetValues(typeof(Marca)))
            {
                Console.WriteLine("{0}: -{1}", i, Enum.GetName(typeof(Marca), i));
            }
            Console.WriteLine("Seleione a marca conforme as opcoes acima: ");
            int entradaMarca = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira o modelo do carro: ");
            string entradaModelo = Console.ReadLine();

            Console.WriteLine("Insira a cor do carro: ");
            string entradaCor = Console.ReadLine();

            Console.WriteLine("Insira o ano do carro: ");
            int entradaAno = int.Parse(Console.ReadLine());
        }
    
        private static string ReceberOpcaoUsuario()
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