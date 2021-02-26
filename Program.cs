using System; 

namespace CadastroEstoque
{
    class Program
    {
        static CarroRepositorio EstoqueCarros = new CarroRepositorio();
        static void Main(string[] args)
        {
            string OpcapUser = ObterOpcaoUser();
            while (OpcapUser != "0")
            {
                switch(OpcapUser)
                {
                    case "1":
                        ListarCarros();
                        break;
                    case "2":
                        InserirCarro();
                        break;
                    case "3":
                        //AttCarro();
                        break;
                    case "4":
                        //ExcluiCarro();
                        break;
                    case "5":
                        //ExibirCarro();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                OpcapUser = ObterOpcaoUser();                
            }
            Console.WriteLine("Saindo do estoque!!!");
            Console.ReadLine();
        }
        private static void ListarCarros()
        {
            Console.WriteLine("Carros em Estoque");

            var lista = EstoqueCarros.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Estoque Vazio!!");
            }
            foreach (var Carro in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", Carro.retornaModelo(), Carro.retornaId());

            }   
        }
        private static void InserirCarro()
        {
            Console.WriteLine("Insira o carro no estoque");

            foreach (int i in Enum.GetValues(typeof(Marca)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Marca), i));
            }
                Console.WriteLine("Escolha a marca do carro: ");
                int entradaMarca = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o modelo do carro: ");
                string entradaModelo = Console.ReadLine();

                Console.WriteLine("Informe a cor do carro: ");
                string entradaCor = Console.ReadLine();

                Console.WriteLine("Informe o ano do carro");
                int entradaAno = int.Parse(Console.ReadLine());

                CRUDItens NovoRegistro = new CRUDItens(id: EstoqueCarros.ProximoId(),
                                                        marca: (Marca)entradaMarca,
                                                        modelo: entradaModelo,
                                                        cor: entradaCor,
                                                        ano: entradaAno);
                EstoqueCarros.Insere(NovoRegistro);
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