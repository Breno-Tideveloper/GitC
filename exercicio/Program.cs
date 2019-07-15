using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    class Program0
    {
        static void Main(string[] args)
        {
            string[,] listaDePessoa = new string[2, 3];
            int IdParaLista = 0;

            for (int i = 0; i < listaDePessoa.GetLength(0); i++)
            {

                Console.WriteLine("\r\n       Seja Bem Vindo       ");  
                Console.WriteLine("\r\n   Insira nome da pessoa:    ");
                var nome = Console.ReadLine();
                Console.WriteLine("\r\nInsira sexo da pessoa masculino (M), Feminino (F)");
                var sexo = Console.ReadKey().KeyChar.ToString();

                listaDePessoa[i, 0] = (IdParaLista++).ToString(); 
                listaDePessoa[i, 1] = nome;
                listaDePessoa[i, 2] = sexo;


                Console.WriteLine("\n\rDeseja inserir um novo registro? sim(1) ou não(0)");
                 var continuar = Console.ReadKey().KeyChar.ToString();
               
                if (continuar == "0")
                    break;

                

                AumentaTamanhoLista(ref listaDePessoa);

                Console.ReadKey();
            }


            for (int i = 0; i < listaDePessoa.GetLength(0); i++)               
                Console.WriteLine(string.Format("Registro ID - {0} - Nome:{1} - sexo:{2}", listaDePessoa[i, 0], listaDePessoa[i, 1], listaDePessoa[i, 2]));

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

            if (limiteDaLista)
            {
                
                var listaCopia = ListaDeNome;
            
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 3];
                
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                   
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                    ListaDeNome[i, 2] = listaCopia[i, 2];
                }
               
                Console.WriteLine("O tamanho da lista foi atualizado com Sucesso.");
            }

        }
    }
} 
         
    

