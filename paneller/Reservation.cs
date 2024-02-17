using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{
    public class Reservation : IReservable
    {
        
        public  static List<Info> reservations;

        string IReservable.isim { get; set; }
        string IReservable.soyisim { get; set; }
        string IReservable.TCNumarası { get; set; }
        Company IReservable.firma { get; set; }
        Vehicle IReservable.arac { get; set; }
        int IReservable.koltukNumarası { get; set; }

        static Reservation()
        {
            reservations = new List<Info>();
        }

        public class Info
        {
            public int biletSayisi;
            public String isim;
            public String soyisim;
            public String TCNumarası;
            public Company firma;
            public Vehicle arac;
            public int koltukNumarası;
        }
    }
}
