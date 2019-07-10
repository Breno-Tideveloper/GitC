using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Teste_dia_10_07
{
    class Program
    {
        public static object Thread { get; private set; }
        public static int i { get; private set; }

        static void Main(string[] args)
        {
            String[] nameList = new string[2] { "Valor 1", "Valor 2" };

            foreach (var item in nameList)
                Console.WriteLine(item);

            string[] dateList = new string[10000];
            DateTime firsrtTime = DateTime.Now;

            for (int i = 0; i < dateList.Length; i++)
            {
                dateList[i] = DateTime.Now.ToString("yyyyMMddhhmmssfff");
                Console.WriteLine(dateList[i]);
            }
            Console.WriteLine((DateTime.Now - firsrtTime).ToString());

            Console.ReadKey();
        }
    }
}