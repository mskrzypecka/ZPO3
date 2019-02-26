using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO3.Wojownicy
{
    public class Rycerz : Wojownik
    {
        public override string Opis => "Rycerz";

        public override string DawajOpis() => Opis;

        public override double ObliczKoszt() => 1000;
    }
}
