using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandovaloresValoresEmumaListaManualmente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da nossa lista o.0
            string[,] listaDeNome = new string[10, 2];
            //Aqui vamos criar uma forma externa de indentifcar nossos registro
            int IdParaLista = 0;
            //Aqui estaremos em um laço para informar nossos registro
            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();
            var nome = Console.ReadLine();


            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {

                //indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("Informa um nome para adicionar um registro:");
                nome = Console.ReadLine();
                //

                

                listaDeNome[i, 0] = (IdParaLista++).ToString();
                listaDeNome[i, 1] = nome;

                Console.WriteLine("Deseja inserir um novo registro? sim(1)  ou não (0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;
            }

            Console.WriteLine("registro adicionados com sucesso, segue lista de informaçoes adicionadas:");

            for (int i = 0; i < listaDeNome.GetLength(0); i++)

                Console.WriteLine(string.Format("registro ID {0} - nome:{1}", listaDeNome[1, 0], listaDeNome[i, 1]));


            Console.ReadKey();


        }
        public static void InsereRegistro(ref string[,] listaDeNome, ref int IdParaLista)
        {


            //Aqui estaremos em um laço para informar nossos registro
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i, 0] != null)
                    continue;

                //indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("Informa um nome para adicionar um registro:");
                var nome = Console.ReadLine();
                //

                

                listaDeNome[i, 0] = (IdParaLista++).ToString();
                listaDeNome[i, 1] = nome;

                Console.WriteLine("Deseja inserir um novo registro? sim(1)  ou não (0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;
            }

            Console.WriteLine("registro adicionados com sucesso, segue lista de informaçoes adicionadas:");

            for (int i = 0; i < listaDeNome.GetLength(0); i++)

                Console.WriteLine(string.Format("registro ID {0} - nome:{1}", listaDeNome[1, 0], listaDeNome[i, 1]));


            Console.ReadKey();
        }
        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {

            var limiteDaLista = true;
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                if (ListaDeNome[i, 0] == null)
                 limiteDaLista = false;
        }

           
        }

         
    }
}
