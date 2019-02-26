using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO3._3.ObslugaZamowienia
{
    public class ZrealizujZamowienie : IPolecenie
    {
        Zamowienie zamowienie;

        public ZrealizujZamowienie(Zamowienie zamowienie)
        {
            this.zamowienie = zamowienie;
        }

        public void Wykonaj() => zamowienie.ZrealizujZamowienie();
    }
}
