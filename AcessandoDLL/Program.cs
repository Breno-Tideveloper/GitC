using CalculadoraInterestelar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoDLL
{
    class Program
    {
        static void Main(string[] args)
        {
             

            MostrandoCalculadoraInterestelar c = new MostrandoCalculadoraInterestelar();
            Console.WriteLine($"somar {c.CalculadoraAdicao(20, 55)}");
            Console.WriteLine($"Divisao {c.CalculadoraDivisao(20, 55)}");
            Console.WriteLine($"Multiplicacao {c.CalculadoraMultiplicacao(20, 55)}");
            Console.WriteLine($"Subtracao {c.CalculadoraSubtracao(20, 55)}");

            Console.ReadKey();
        }
    }
}
