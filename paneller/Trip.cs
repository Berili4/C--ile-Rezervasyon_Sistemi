using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{
    public class Trip
    {
        static Random random = new Random();
        //arac guzergah zaman fiyat 
        public String Name;
        public Vehicle vehicle;
        public List<twoPointTrip> tpTrips;
        public int price;
        public DateTime TarihSefer;

        public Trip() 
        {
            tpTrips = new List<twoPointTrip>();
            TarihSefer = new DateTime(2023, 12, RastgeleGun());
        }

        static int RastgeleGun()
        {
            int randomNumber = random.Next(4, 10 + 1);
            return randomNumber;
        }

    }
}
