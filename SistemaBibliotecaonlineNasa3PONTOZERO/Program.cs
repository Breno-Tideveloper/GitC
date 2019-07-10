using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaonlineNasa3PONTOZERO
{
    class Program
    {
        //  public static int opcao { get; private set; }

        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            MostrarSejaBemVindo();

            if (MenuInicial() == 1)
            {
                Console.Clear();

                MostrarSejaBemVindo();

                Console.WriteLine("Menu - Alocação de livros");
                Console.WriteLine("Digite o nome do livro a ser alocado:");

                var nomedolivro = Console.ReadLine();
                if(PesquisaLivroParaAlocacao(nomedolivro))
                {

                    Console.Clear();
                    Console.WriteLine("Você eseja alocar o livro? para sim(1) para não(0)");


                    int.TryParse(Console.ReadKey().KeyChar.ToString(), out int keypress);
                    if (keypress == 1)
                    {
                        Console.Clear();
                        AlocarLivro(nomedolivro);
                        Console.WriteLine("Livro Alocado com sucesso!");
                    }
                    else
                        Console.Clear();
                    Console.WriteLine("Listagem de Livros:");

                    for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                    {
                        Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponivel: {baseDeLivros[i, 1]}");
                    }
                }

                /*Console.WriteLine("Você eseja alocar o livro? para sim(1) para não(0)");
                var alocarLivro = Console.ReadKey();*/

                //for (int i = 0; i  < baseDeLivros.GetLength(0); i++)
                //{
                //    Console.WriteLine($"O livro:{baseDeLivros[i, 1]} pode ser alocado?:{baseDeLivros[i, 1]}");

                //    poderserAlocado = baseDeLivros[i, 1] == "sim";
                //}

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

        public static int MenuInicial()
        {

            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Sair do sistema.");
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
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "não";
            }
        }
     }


}    




