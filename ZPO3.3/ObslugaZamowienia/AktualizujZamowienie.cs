using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO3._3.ObslugaZamowienia
{
    public class AktualizujZamowienie : IPolecenie
    {
        Zamowienie zamowienie;

        public AktualizujZamowienie(Zamowienie zamowienie)
        {
            this.zamowienie = zamowienie;
        }

        public void Wykonaj() => zamowienie.ModyfikujZamowienie();
    }
}
