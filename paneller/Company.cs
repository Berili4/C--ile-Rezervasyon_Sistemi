using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paneller
{
    public class Company : User, IProfitable
    {

        public List<Bus> buses;
        public List<Train> trains;
        public List<Airplane> airplanes;
        public List<Trip> trips;
        public float FuelPrice_Benzin;
        public float FuelPrice_Motorin;
        public float FuelPrice_Elektrik;
        public float FuelPrice_Gaz;

        public Company()
        {
            //araçları oluştur listeden al trip'e yolla trip düzenle
            buses = new List<Bus>();

            trains = new List<Train>();

            airplanes = new List<Airplane>();

            trips = new List<Trip>();


        }

        public int Maliyet { get; set; }
        string IProfitable.FuelPrice_Benzin { get; set; }
        string IProfitable.FuelPrice_Motorin { get; set; }
        string IProfitable.FuelPrice_Elektrik { get; set; }
        string IProfitable.FuelPrice_Gaz { get; set; }

        public override string ToString()
        {
            return "Firma Adı: "+Kullaniciadi;
        }

    }
    
}

