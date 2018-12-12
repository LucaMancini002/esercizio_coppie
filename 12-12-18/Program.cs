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
            do
            {
                Console.WriteLine("inserisci un numero intero da convertire");
                num = Convert.ToInt32(Console.ReadLine());//inserisco num
            } while (num < 0);//controllo il numero 
           
            do
            {
                Console.WriteLine("inserisci la base in cui vuoi convertire, 2, 8 oppure 16");
                bbase = Convert.ToInt32(Console.ReadLine());//inserisco base

            } while (bbase != 2 && bbase != 8 && bbase!=16);//controllo la base
           
            string convertitore= Convert.ToString(num, bbase);//converto
           
            risultato = Convert.ToString(num,bbase) + risultato;
            Console.WriteLine($"il numero convertito in base {bbase} è {risultato}");

            Console.ReadLine();
        }
    }
}
