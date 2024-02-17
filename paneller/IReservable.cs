using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{
    internal interface IReservable
    {
        String isim { get; set; }
        String soyisim { get; set; }
        String TCNumarası { get; set; }
        Company firma { get; set; }
        Vehicle arac { get; set; }
        int koltukNumarası { get; set; }
    }
}
