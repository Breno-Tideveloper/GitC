using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemoveList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 3];

            int IndiceBaseDeDado = 0;


            Console.WriteLine("Iniciando sistema de lsta de nome e idade.");
            var escolhaInicial = ApresentaMenuInicial();

            while (true)
                switch (escolhaInicial)
                {
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDado); } break;
                    case "2": { } break;
                    case "3": { } break;
                    case "4":
                        {

                            return;

                        }

                }
            escolhaInicial = ApresentaMenuInicial();

        }




        public static string ApresentaMenuInicial()
        {
            Console.WriteLine("1- Menu");
            Console.WriteLine("2- Remover um novo registro");
            Console.WriteLine("3- Lstar informações.");
            Console.WriteLine("4- Sair do sistema.");

            Console.WriteLine(" Digite o numero da opção desejada:");

            return Console.ReadLine();



        }
        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int IndiceBase)
        {
            for (int i = 0; i < baseDeDados.Length; i++)
            {

            }
        }
        public static void MostrarInformaçoes(string[,] baseDeDados)
        {

            Console.WriteLine("Apresentação das informaçoes dentro da base de dados");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID {baseDeDados[1, 0]}") +
                    $"- Nome: {baseDeDados}"
            {

            }
        }
        public static void RemoverInformações()
    }
}
