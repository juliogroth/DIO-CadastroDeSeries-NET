using System;

namespace CadastroSeries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio(); 
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper()!="X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        MenuListarSeries();
                        break;
                    case "2":
                        MenuInserirSerie();
                         break;
                    case "3":
                        MenuAtualizaSerie();
                         break;
                    case "4":
                        MenuExcluiSerie();
                         break;
                    case "5":
                        MenuVisualizaSerie();
                         break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();
        }

        private static void MenuListarSeries()
        {
            Console.WriteLine("Listar Séries");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nennhuma serie cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                if (serie.retornaExcluido() == false)
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
                }
                
            }
        }

        private static void MenuInserirSerie()
        {
            foreach (int i in Enum.GetValues(typeof(Genero))) // para cada linha cadastrada no Enum vai imprimir 
            //o índice e o nome cadastrado. E se adicionar novo genero, não será preciso alterar aqui.
            {
                Console.WriteLine("{0} - {1}",i, Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o numero do genero da serie dentre as opcoes acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da série:");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Insira a descriçao da série:");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Insira o ano de produção da série:");
            int entradaAno = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);
            
            repositorio.Insere(novaSerie);
        }

        private static void MenuAtualizaSerie()
        {
            Console.Write("Digite o id da série a ser atualizada:");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}",i, Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o numero do genero da serie dentre as opcoes acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da série:");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Insira a descriçao da série:");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Insira o ano de produção da série:");
            int entradaAno = int.Parse(Console.ReadLine());

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);
            
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        
        public static void MenuExcluiSerie()
        {
            Console.Write("Digite o id da série a ser Excluída:");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }

        public static void MenuVisualizaSerie()
        {
            Console.Write("Digite o id da série a ser visualizada:");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetoraPorId(indiceSerie);

            Console.WriteLine(serie);
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opcao desejada:");
            Console.WriteLine("1 - Listar series;");
            Console.WriteLine("2 - Inserir nova serie;");
            Console.WriteLine("3 - Atualizar serie;");
            Console.WriteLine("4 - Excluir serie;");
            Console.WriteLine("5 - Visualizar serie;");
            Console.WriteLine("C - Limpar a tela;");
            Console.WriteLine("X - Sair.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();           
            return opcaoUsuario;
        }
    }
}
