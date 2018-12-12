using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_12_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string risultato = " ";
            int num, bbase;
            Console.WriteLine("inserisci un numero da convertire");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci la base in cui vuoi convertire");
            bbase = Convert.ToInt32(Console.ReadLine());

            string convertitore= Convert.ToString(num, bbase);//converto
           
            risultato = Convert.ToString(num,bbase) + risultato;
            Console.WriteLine($"il numero convertito in base{bbase} è{risultato}");

            Console.ReadLine();
        }
    }
}
