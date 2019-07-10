using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsolearray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivros = new string[2, 2]
                {{"O pequeno","Sim"},{"O grande","não"} };

            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                var Nomelivro = listaDeLivros[i, 0];
                var Disponivel = listaDeLivros[i, 1];

                Console.WriteLine($"Nome do livro:{Nomelivro} disponivel: {Disponivel}.");
                
            }
            Console.ReadKey();

        }
    }
}
