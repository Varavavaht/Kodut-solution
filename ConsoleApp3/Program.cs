using System;
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
            Console.WriteLine("Arvuti genereeris suvalise arvu 1-st 100-ni. Arva see ära!");
            Console.Write("Sisesta number 1-st 100-ni: ");
            //Võrreldes ülesandega 4 vahetasin proovimiseks bool'is ja while'is true ja false'id omavahel. Kuidas õigem vüi loogilisem on?
            bool arvamine = false;
            while (arvamine == false)
            {
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
                if (magicarv != arv)
                {
                    Console.Write("Sisesta uus number:");
                }
                if (magicarv == arv)
                {
                    break;
                }
            }
            Console.WriteLine("Sa valisid õige numbri!");
            Console.ReadLine();
        }
    }
}
