using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO3.Wojownicy;

namespace ZPO3.Dekoratory
{
    public class Miecz : DekoratorWojownikow
    {
        public override string Opis => wojownik.Opis + " Miecz";

        public Miecz(Wojownik wojownik) : base(wojownik) {}

        public override string DawajOpis() => Opis;

        public override double ObliczKoszt() => wojownik.ObliczKoszt() + 250;
    }
}
