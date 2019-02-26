using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO3.Wojownicy;

namespace ZPO3.Dekoratory
{
    public class Helm : DekoratorWojownikow
    {
        public override string Opis => wojownik.Opis + " Helm";

        public Helm(Wojownik wojownik) : base(wojownik) {}

        public override string DawajOpis() => Opis;

        public override double ObliczKoszt() => wojownik.ObliczKoszt() + 100;
    }
}
