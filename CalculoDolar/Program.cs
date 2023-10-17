using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cotacaoDolar = 4.99f;
            Console.WriteLine("Valor:");
            float reais = int.Parse(Console.ReadLine());
            Console.WriteLine(reais / cotacaoDolar);
            Console.ReadLine();
        }
    }
}
