using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO3.Wojownicy
{
    public abstract class Wojownik
    {
        public abstract string DawajOpis();
        public abstract double ObliczKoszt();

        public abstract string Opis { get; }
    }
}
