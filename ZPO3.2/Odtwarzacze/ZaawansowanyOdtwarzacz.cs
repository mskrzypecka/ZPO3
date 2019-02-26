using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO3._2.Odtwarzacze
{
    class ZaawansowanyOdtwarzacz
    {
        internal void GrajMp4(string sciezkaDoPliku) 
            => Console.WriteLine("Gra mp4 o sciezce: " + sciezkaDoPliku);

        internal void GrajWMV(string sciezkaDoPliku)
            => Console.WriteLine("Gra wmv o sciezce: " + sciezkaDoPliku);
    }
}
