using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNasci = Convert.ToDateTime(Console.ReadLine());
            var idade = DateTime.Today.Year - dataNasci.Year;
            if (DateTime.Today.DayOfYear < dataNasci.DayOfYear)
                idade = idade - 1;
            Console.WriteLine(idade);
            Console.ReadKey();

        }
    }
}
