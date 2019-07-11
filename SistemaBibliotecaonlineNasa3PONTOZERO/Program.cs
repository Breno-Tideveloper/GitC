using System;

namespace SistemaBibliotecaonlineNasa3PONTOZERO
{
    class Program
    {
        //  public static int opcao { get; private set; }

        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    AlocarUmLivro();

                if (opcaoMenu == 2)
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
            }
            Console.ReadKey();

            if (MenuPrincipal() == 1)
            {
                AlocarUmLivro();

            }

            Console.ReadKey();
        }
        /// <summary>
        /// metodo para mostrar munu incial do sistema.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________");
            Console.WriteLine("     Sistema de alocação de livros");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("    Desenvolvido pela empresa BrenoS");
            Console.WriteLine("__________________________________________");

        }
        /// <summary>
        /// Metodo que mostar o menu inicial com as opções para escolha
        /// </summary>
        /// <returns>Retorna o numero do menu escolhido.</returns>

        public static int MenuPrincipal()
        {

            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - Sair do sistema.");
            Console.WriteLine("Digite o numero desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2] {

                {"O pequeno","Sim" },
                  {"O grande","não" }
        };

        }

        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado
        /// </summary>
        /// <param name="nomeLivro">Nome livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {

                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro:{baseDeLivros[i, 0]} pode ser alocado?:{baseDeLivros[i, 1]}");
                    return baseDeLivros[i, 1] == "Sim";
                }
            }

            return false;

        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>


        public static void AlocarLivro(string nomeLivro, bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    baseDeLivros[i, 1] = alocar ? "não" : "sim";
                }

            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Livro Atualizado com sucesso!");
        }
        /// <summary>
        /// metodo de alocar livro.
        /// </summary>
        public static void AlocarUmLivro()
        {
            MostrarMenuInicialLivros("Alocar um livro");

            var nomedolivro = Console.ReadLine();

            if (PesquisaLivroParaAlocacao(nomedolivro))
            {

                Console.Clear();
                Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");


                int.TryParse(Console.ReadKey().KeyChar.ToString(), out int keypress);
                //   if (keypress == 1)
                //   {
                AlocarLivro(nomedolivro, keypress == 1);
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Livro Alocado com sucesso!");
                // }
                //  else
                //      Console.Clear();

                //  MostrarSejaBemVindo();


                Console.ReadKey();
            }
        }
        /// <summary>
        /// metodo que mostra a lista de livros atualizados
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de livros:");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponivel:{baseDeLivros[i, 1]}");
            }
        }
        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro:");

            MostrarListaDeLivros();

            var nomedolivro = Console.ReadLine();
            if (!PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o livro? para sim(1) para não(0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação:");
        }


    }
}






