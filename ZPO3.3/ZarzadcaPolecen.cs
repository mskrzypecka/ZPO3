using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO3._3
{
    public class ZarzadcaPolecen
    {
        IList<IPolecenie> polecenia;

        public ZarzadcaPolecen()
        {
            polecenia = new List<IPolecenie>();
        }

        public void UstawPolecenie(IPolecenie polecenie)
            => polecenia.Add(polecenie);

        public void UsunOstatniePolecenie()
            => polecenia.RemoveAt(polecenia.Count - 1);

        public void WykonajPrace()
            => polecenia.ToList().ForEach(x => x.Wykonaj());
    }
}
