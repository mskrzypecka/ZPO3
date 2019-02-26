using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO3.Dekoratory;
using ZPO3.Wojownicy;

namespace ZPO3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rycerz_1 = new Rycerz();
            var wyposazony_1 = new Zbroja(new Helm(new Tarcza(new Miecz(new DekoratorWojownikow(rycerz_1)))));
            Console.WriteLine("rycerz_1");
            Console.WriteLine(wyposazony_1.Opis);
            Console.WriteLine("Koszt: " + wyposazony_1.ObliczKoszt());

            Console.WriteLine("___________________");

            var rycerz_2 = new Rycerz();
            var wyposazony_2 = new Miecz(new Miecz(new DekoratorWojownikow(rycerz_2)));
            Console.WriteLine("rycerz_2");
            Console.WriteLine(wyposazony_2.Opis);
            Console.WriteLine("Koszt: " + wyposazony_2.ObliczKoszt());

            Console.ReadKey();
        }
    }
}
