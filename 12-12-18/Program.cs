﻿using System;
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
            int num = 225;

            while (num > 1)
            {
                int resto = num % 2;
                risultato = Convert.ToString(resto) + risultato;
                num = num / 2;
            }
            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"il numero binario è{risultato}");

            Console.ReadLine();
        }
    }
}
