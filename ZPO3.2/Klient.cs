using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO3._2
{
    class Klient
    {
        private Adapter adapter;

        public Klient(Adapter adapter)
        {
            this.adapter = adapter;
        }

        internal void Graj(string typPliku, string sciezkaDoPliku)
        {
            adapter.Graj(typPliku, sciezkaDoPliku);
        }
    }
}
