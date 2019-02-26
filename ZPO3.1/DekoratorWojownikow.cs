using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO3.Wojownicy;

namespace ZPO3
{
    public class DekoratorWojownikow : Wojownik
    {
        protected Wojownik wojownik;
        public override string Opis => wojownik.Opis;

        public DekoratorWojownikow(Wojownik wojownik) => this.wojownik = wojownik;

        public override string DawajOpis() => wojownik.DawajOpis();

        public override double ObliczKoszt() => wojownik.ObliczKoszt();
    }
}
