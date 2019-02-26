using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO3._2.Odtwarzacze;

namespace ZPO3._2
{
    class Adapter
    {
        public void Graj(string typPliku, string sciezkaDoPliku)
        {
            switch (typPliku)
            {
                case "mp3":
                    var mp3 = new Odtwarzacz();
                    mp3.Graj(sciezkaDoPliku);
                    break;
                case "wmv":
                    var wmv = new ZaawansowanyOdtwarzacz();
                    wmv.GrajWMV(sciezkaDoPliku);
                    break;
                case "mp4":
                    var mp4 = new ZaawansowanyOdtwarzacz();
                    mp4.GrajMp4(sciezkaDoPliku);
                    break;
                default:
                    break;
            }
        }
    }
}
