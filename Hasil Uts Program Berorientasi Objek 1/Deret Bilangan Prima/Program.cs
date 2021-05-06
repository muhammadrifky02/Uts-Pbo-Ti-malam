using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TUGAS_BIL_PRIMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan batas atas bilangan prima : ");
            //inisialisasi
            bool prima = true;
            int bilangan = int.Parse(Console.ReadLine());

            if (bilangan >= 2)
            {
                //loop hingga batas bilangan tercapai
                for (int i = 2; i <= bilangan; i++)
                {
                    //loop mulai dari 2 ke i
                    for (int j = 2; j < i; j++)
                    {
                        //bukan blangan prima jika i habis dibagi j
                        if ((i % j) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }
                    //jika bilangan == prima
                    if (prima)
                        Console.Write(+i + "  ");
                    prima = true;
                }
            }
            else Console.WriteLine("tidak ada bilangan prima");
            Console.ReadLine();
        }
    }
}