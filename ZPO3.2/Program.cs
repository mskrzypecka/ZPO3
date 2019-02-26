using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = @"path/path/path";

            Adapter adapter = new Adapter();
            Klient klient = new Klient(adapter);
            klient.Graj("mp3", sciezka);
            klient.Graj("wmv", sciezka);
            klient.Graj("mp4", sciezka);

            Console.ReadKey();
        }
    }
}
