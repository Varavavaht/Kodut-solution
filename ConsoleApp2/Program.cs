﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int magicarv = rnd.Next(1, 100);
            Console.Write("Sisesta number 1-st 100-ni: ");
            string input1 = Console.ReadLine();
            int arv = int.Parse(input1);
            Console.WriteLine("Sa valisid arvu " + input1);

            if (magicarv < arv)
            {
                Console.WriteLine("Sinu arv on liiga suur");
            }
            if (magicarv > arv)
            {
                Console.WriteLine("Sinu pakutud arv on liiga väike");
            }
            bool edukus = true;
            while (edukus)
                if (arv == magicarv)
                {
                    Console.WriteLine("Sa arvasid õigesti!");

                }
            Console.WriteLine("Paku uuesti!");


        }
    }
}
