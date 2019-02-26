using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO3._3.ObslugaZamowienia;

namespace ZPO3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ZarzadcaPolecen zarzadca = new ZarzadcaPolecen();

            Zamowienie zamowienie_1 = new Zamowienie();
            zarzadca.UstawPolecenie(new StworzZamowienie(zamowienie_1));

            Zamowienie zamowienie_2 = new Zamowienie();
            zarzadca.UstawPolecenie(new StworzZamowienie(zamowienie_2));

            Zamowienie zamowienie_3 = new Zamowienie();
            zarzadca.UstawPolecenie(new StworzZamowienie(zamowienie_3));

            zarzadca.UstawPolecenie(new AktualizujZamowienie(zamowienie_2));

            zarzadca.UstawPolecenie(new ZrealizujZamowienie(zamowienie_1));
            zarzadca.UstawPolecenie(new ZrealizujZamowienie(zamowienie_2));

            zarzadca.WykonajPrace();

            Console.ReadKey();
        }
    }
}
