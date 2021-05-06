using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_Konversi_Bilangan_des_to_biner
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Masukan Bilangan Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}",result);
        }
    }
}