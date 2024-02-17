using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static paneller.Route;

namespace paneller
{
    public class DB
    {
        //kara
        public static List<String> kara_tum;
        public static List<String> kara_ist;
        public static List<String> kara_koc;
        public static List<String> kara_ank;
        public static List<String> kara_esk;
        public static List<String> kara_kon;
        //ray
        public static List<String> ray_tum;
        public static List<String> ray_ist;
        public static List<String> ray_koc;
        public static List<String> ray_bil;
        public static List<String> ray_ank;
        public static List<String> ray_esk;
        public static List<String> ray_kon;
        //hava
        public static List<String> hava_tum;
        public static List<String> hava_ist;
        public static List<String> hava_ank;
        public static List<String> hava_kon;


        public static List<Company> companies = new List<Company>();
        public static List<twoPointTrip> stopsLand = new List<twoPointTrip>();
        public static List<twoPointTrip> stopsRail = new List<twoPointTrip>();
        public static List<twoPointTrip> stopsAir = new List<twoPointTrip>();
        public static List<Trip> defaultTrips = new List<Trip>();
        public static List<String> vehiclesCombo = new List<String>();
        public static int hizmetBedeli=1000;
        static DB()
        {
            //comboboxvehiclelist
            vehiclesCombo.Add("Otobüs");
            vehiclesCombo.Add("Tren");
            vehiclesCombo.Add("Uçak");

            //her sehirden gidilebilecek diğer sehirler
            //kara
            kara_tum = new List<string>() { "İstanbul", "Kocaeli", "Ankara", "Eskişehir", "Konya" };
            kara_ist = new List<string>() {"Kocaeli","Ankara","Eskişehir","Konya"};
            kara_koc = new List<string>() {"İstanbul","Ankara","Eskişehir","Konya" };
            kara_ank = new List<string>() { "İstanbul","Kocaeli"};
            kara_esk = new List<string>() { "İstanbul","Kocaeli","Konya" };
            kara_kon = new List<string>() { "İstanbul","Kocaeli", "Eskişehir" };
            //ray
            ray_tum = new List<string>() { "İstanbul", "Kocaeli", "Bilecik", "Ankara", "Eskişehir", "Konya" };
            ray_ist = new List<string>() { "Kocaeli", "Bilecik", "Ankara", "Eskişehir", "Konya" };
            ray_koc = new List<string>() { "İstanbul", "Bilecik", "Ankara", "Eskişehir", "Konya" };
            ray_bil = new List<string>() {"İstanbul", "Kocaeli", "Ankara", "Eskişehir", "Konya" };
            ray_ank = new List<string>() {"İstanbul", "Kocaeli", "Bilecik", "Eskişehir" };
            ray_esk = new List<string>() { "İstanbul", "Kocaeli", "Bilecik", "Ankara", "Konya" };
            ray_kon = new List<string>() { "İstanbul", "Kocaeli", "Bilecik", "Eskişehir" };
            //hava
            hava_tum = new List<string>() { "İstanbul", "Ankara", "Konya" };
            hava_ist = new List<string>() { "Ankara", "Konya" };
            hava_ank = new List<string>() { "İstanbul" };
            hava_kon = new List<string>() { "İstanbul"};

            //rotalar
            //istkara
            //0
            stopsLand.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Kocaeli",
                Distance = 100
            });
            //1
            stopsLand.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Ankara",
                Distance = 500
            });
            //2
            stopsLand.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Eskişehir",
                Distance = 300
            });
            //3
            stopsLand.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Konya",
                Distance = 600
            });
            //kockara
            //4
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "İstanbul",
                Distance = 100
            });
            //5
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "Ankara",
                Distance = 400
            });
           
            //6
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "Eskişehir",
                Distance = 200
            });
            //7
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "Konya",
                Distance = 500
            });
            //ankkara
            //8
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Ankara",
                End = "İstanbul",
                Distance = 500
            });
            //9
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Ankara",
                End = "Kocaeli",
                Distance = 400
            });
            //eskkara
            //10
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Eskişehir",
                End = "İstanbul",
                Distance = 300
            });
            //11
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Eskişehir",
                End = "Kocaeli",
                Distance = 200
            });
            //12
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Eskişehir",
                End = "Konya",
                Distance = 300
            });
            //konkara
            //13
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Konya",
                End = "İstanbul",
                Distance = 600
            });
            //14
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Konya",
                End = "Kocaeli",
                Distance = 500
            });
            //15
            stopsLand.Add(new twoPointTrip()
            {
                Start = "Konya",
                End = "Eskişehir",
                Distance = 300
            });


            //istray
            //0
            stopsRail.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Kocaeli",
                Distance = 75
            });
            //1
            stopsRail.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Bilecik",
                Distance = 225
            });
            //2
            stopsRail.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Ankara",
                Distance = 375
            });
            //3
            stopsRail.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Eskişehir",
                Distance = 300
            });
            //4
            stopsRail.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Konya",
                Distance = 450
            });
            //kocray
            //5
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "İstanbul",
                Distance = 75
            });
            //6
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "Bilecik",
                Distance = 75
            });
            //7
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "Ankara",
                Distance = 300
            });
            //8
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "Eskişehir",
                Distance = 150
            });
            //9
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Kocaeli",
                End = "Konya",
                Distance = 350
            });
            //bilray
            //10
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Bilecik",
                End = "İstanbul",
                Distance = 225
            });
            //11
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Bilecik",
                End = "Kocaeli",
                Distance = 75
            });
            //12
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Bilecik",
                End = "Ankara",
                Distance = 225
            });
            //13
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Bilecik",
                End = "Eskişehir",
                Distance = 75
            });
            //14
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Bilecik",
                End = "Konya",
                Distance = 300
            });
            //ankray
            //15
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Ankara",
                End = "İstanbul",
                Distance = 375
            });
            //16
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Ankara",
                End = "Kocaeli",
                Distance = 300
            });
            //17
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Ankara",
                End = "Bilecik",
                Distance = 225
            });
            //18
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Ankara",
                End = "Eskişehir",
                Distance = 150
            });
            //eskray
            //19
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Eskişehir",
                End = "İstanbul",
                Distance = 300
            });
            //20
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Eskişehir",
                End = "Kocaeli",
                Distance = 150
            });
            //21
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Eskişehir",
                End = "Bilecik",
                Distance = 75
            });
            //22
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Eskişehir",
                End = "Ankara",
                Distance = 150
            });
            //23
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Eskişehir",
                End = "Konya",
                Distance = 225
            });
            //konray
            //24
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Konya",
                End = "İstanbul",
                Distance = 450
            });
            //25
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Konya",
                End = "Kocaeli",
                Distance = 350
            });
            //26
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Konya",
                End = "Bilecik",
                Distance = 300
            });
            //27
            stopsRail.Add(new twoPointTrip()
            {
                Start = "Konya",
                End = "Eskişehir",
                Distance = 225
            });


            //istair
            //0
            stopsAir.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Ankara",
                Distance = 250
            });
            //1
            stopsAir.Add(new twoPointTrip()
            {
                Start = "İstanbul",
                End = "Konya",
                Distance = 300
            });
            //ankair
            //2
            stopsAir.Add(new twoPointTrip()
            {
                Start = "Ankara",
                End = "İstanbul",
                Distance = 250
            });
            //konair
            //3
            stopsAir.Add(new twoPointTrip()
            {
                Start = "Konya",
                End = "İstanbul",
                Distance = 300
            });

            //setup default trips
            //0
            defaultTrips.Add(new Trip() { Name = "1. sefer (Demiryolu)" });
            defaultTrips.ElementAt(0).tpTrips.Add(DB.stopsRail.ElementAt(0));
            defaultTrips.ElementAt(0).tpTrips.Add(DB.stopsRail.ElementAt(6));
            defaultTrips.ElementAt(0).tpTrips.Add(DB.stopsRail.ElementAt(13));
            defaultTrips.ElementAt(0).tpTrips.Add(DB.stopsRail.ElementAt(22));
            defaultTrips.ElementAt(0).tpTrips.Add(DB.stopsRail.ElementAt(18));
            defaultTrips.ElementAt(0).tpTrips.Add(DB.stopsRail.ElementAt(21));
            defaultTrips.ElementAt(0).tpTrips.Add(DB.stopsRail.ElementAt(11));
            defaultTrips.ElementAt(0).tpTrips.Add(DB.stopsRail.ElementAt(5));
            //1
            defaultTrips.Add(new Trip() { Name = "2. sefer (Demiryolu)" });
            defaultTrips.ElementAt(1).tpTrips.Add(DB.stopsRail.ElementAt(0));
            defaultTrips.ElementAt(1).tpTrips.Add(DB.stopsRail.ElementAt(6));
            defaultTrips.ElementAt(1).tpTrips.Add(DB.stopsRail.ElementAt(13));
            defaultTrips.ElementAt(1).tpTrips.Add(DB.stopsRail.ElementAt(23));
            defaultTrips.ElementAt(1).tpTrips.Add(DB.stopsRail.ElementAt(27));
            defaultTrips.ElementAt(1).tpTrips.Add(DB.stopsRail.ElementAt(21));
            defaultTrips.ElementAt(1).tpTrips.Add(DB.stopsRail.ElementAt(11));
            defaultTrips.ElementAt(1).tpTrips.Add(DB.stopsRail.ElementAt(5));
            //2
            defaultTrips.Add(new Trip() { Name = "3. sefer (Karayolu)" });
            defaultTrips.ElementAt(2).tpTrips.Add(DB.stopsLand.ElementAt(0));
            defaultTrips.ElementAt(2).tpTrips.Add(DB.stopsLand.ElementAt(5));
            defaultTrips.ElementAt(2).tpTrips.Add(DB.stopsLand.ElementAt(9));
            defaultTrips.ElementAt(2).tpTrips.Add(DB.stopsLand.ElementAt(4));
            //3
            defaultTrips.Add(new Trip() { Name = "4. sefer (Karayolu)" });
            defaultTrips.ElementAt(3).tpTrips.Add(DB.stopsLand.ElementAt(0));
            defaultTrips.ElementAt(3).tpTrips.Add(DB.stopsLand.ElementAt(6));
            defaultTrips.ElementAt(3).tpTrips.Add(DB.stopsLand.ElementAt(12));
            defaultTrips.ElementAt(3).tpTrips.Add(DB.stopsLand.ElementAt(15));
            defaultTrips.ElementAt(3).tpTrips.Add(DB.stopsLand.ElementAt(11));
            defaultTrips.ElementAt(3).tpTrips.Add(DB.stopsLand.ElementAt(4));
            //4
            defaultTrips.Add(new Trip() { Name = "5. sefer (Havayolu)" });
            defaultTrips.ElementAt(4).tpTrips.Add(DB.stopsAir.ElementAt(1));
            defaultTrips.ElementAt(4).tpTrips.Add(DB.stopsAir.ElementAt(3));
            //5
            defaultTrips.Add(new Trip() { Name = "6. sefer (Havayolu)" });
            defaultTrips.ElementAt(5).tpTrips.Add(DB.stopsAir.ElementAt(0));
            defaultTrips.ElementAt(5).tpTrips.Add(DB.stopsAir.ElementAt(2));

            //setup companies
            companies.Add(new Company() { Kullaniciadi = "A", Sifre = "a", FuelPrice_Benzin = 10 });
            companies.Add(new Company() { Kullaniciadi = "B", Sifre = "b", FuelPrice_Motorin = 5 });
            companies.Add(new Company() { Kullaniciadi = "C", Sifre = "c", FuelPrice_Motorin = 6, FuelPrice_Gaz = 25 });
            companies.Add(new Company() { Kullaniciadi = "D", Sifre = "d", FuelPrice_Elektrik = 3 });
            companies.Add(new Company() { Kullaniciadi = "F", Sifre = "f", FuelPrice_Gaz = 20 });


            //firma A

            companies.ElementAt(0).buses.Add(new Bus()
            {
                ID = "Otobüs1",
                Fuel = "Benzin",
                Capacity = 20,
            });
            companies.ElementAt(0).buses.Last().RandomSeatsAtCapacity();
            companies.ElementAt(0).buses.Add(new Bus()
            {
                ID = "Otobüs2",
                Fuel = "Benzin",
                Capacity = 15
            });
            companies.ElementAt(0).buses.Last().RandomSeatsAtCapacity();

            companies.ElementAt(0).buses[0].personels_driver.Add(new Personel { Ad="da1",Soyad="ds1"});
            companies.ElementAt(0).buses[0].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(0).buses[0].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(0).buses[0].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            companies.ElementAt(0).buses[1].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(0).buses[1].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(0).buses[1].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(0).buses[1].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });


            //Atrips
            //birinci araç
            companies.ElementAt(0).trips.Add(new Trip());
            companies.ElementAt(0).trips.ElementAt(0).tpTrips.AddRange(defaultTrips.ElementAt(2).tpTrips);
            companies.ElementAt(0).trips.ElementAt(0).Name = defaultTrips.ElementAt(2).Name;
            //companies.ElementAt(0).trips.ElementAt(0).ID = "A sefer 3 otobüs1";
            companies.ElementAt(0).trips.ElementAt(0).vehicle = companies.ElementAt(0).buses.ElementAt(0);
            //ikinci araç
            companies.ElementAt(0).trips.Add(new Trip());
            companies.ElementAt(0).trips.ElementAt(1).tpTrips.AddRange(defaultTrips.ElementAt(2).tpTrips);
            companies.ElementAt(0).trips.ElementAt(1).Name = defaultTrips.ElementAt(2).Name;
            //companies.ElementAt(0).trips.ElementAt(1).ID = "A sefer 3 otobüs2";
            companies.ElementAt(0).trips.ElementAt(1).vehicle = companies.ElementAt(0).buses.ElementAt(1);

            //firma B
            companies.ElementAt(1).buses.Add(new Bus()
            {
                ID = "Otobüs1",
                Fuel = "Motorin",
                Capacity= 15
            });
            companies.ElementAt(1).buses.Last().RandomSeatsAtCapacity();
            companies.ElementAt(1).buses.Add(new Bus()
            {
                ID = "Otobüs2",
                Fuel = "Motorin",
                Capacity= 20
            });
            companies.ElementAt(1).buses.Last().RandomSeatsAtCapacity();

            companies.ElementAt(1).buses[0].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(1).buses[0].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(1).buses[0].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(1).buses[0].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            companies.ElementAt(1).buses[1].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(1).buses[1].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(1).buses[1].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(1).buses[1].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            //Btrips
            //birinci araç
            companies.ElementAt(1).trips.Add(new Trip());
            companies.ElementAt(1).trips.ElementAt(0).tpTrips.AddRange(defaultTrips.ElementAt(2).tpTrips);
            companies.ElementAt(1).trips.ElementAt(0).Name = defaultTrips.ElementAt(2).Name;
            companies.ElementAt(1).trips.ElementAt(0).vehicle = companies.ElementAt(1).buses.ElementAt(0);
            //ikinci araç
            companies.ElementAt(1).trips.Add(new Trip());
            companies.ElementAt(1).trips.ElementAt(1).tpTrips.AddRange(defaultTrips.ElementAt(3).tpTrips);
            companies.ElementAt(1).trips.ElementAt(1).Name = defaultTrips.ElementAt(3).Name;
            companies.ElementAt(1).trips.ElementAt(1).vehicle = companies.ElementAt(1).buses.ElementAt(1);

            //firma C
            companies.ElementAt(2).buses.Add(new Bus()
            {
                ID = "Otobüs1",
                Fuel = "Motorin",
                Capacity = 20
            });
            companies.ElementAt(2).buses.Last().RandomSeatsAtCapacity();
            companies.ElementAt(2).airplanes.Add(new Airplane()
            {
                ID = "Uçak1",
                Fuel = "Gaz",
                Capacity = 30
            });
            companies.ElementAt(2).airplanes.Last().RandomSeatsAtCapacity();
            companies.ElementAt(2).airplanes.Add(new Airplane()
            {
                ID = "Uçak2",
                Fuel = "Gaz",
                Capacity= 30
            });
            companies.ElementAt(2).airplanes.Last().RandomSeatsAtCapacity();

            companies.ElementAt(2).buses[0].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(2).buses[0].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(2).buses[0].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(2).buses[0].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            companies.ElementAt(2).airplanes[0].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(2).airplanes[0].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(2).airplanes[0].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(2).airplanes[0].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            companies.ElementAt(2).airplanes[1].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(2).airplanes[1].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(2).airplanes[1].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(2).airplanes[1].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            //Ctrips
            //birinci araç
            companies.ElementAt(2).trips.Add(new Trip());
            companies.ElementAt(2).trips.ElementAt(0).tpTrips.AddRange(defaultTrips.ElementAt(2).tpTrips);
            companies.ElementAt(2).trips.ElementAt(0).Name = defaultTrips.ElementAt(3).Name;
            companies.ElementAt(2).trips.ElementAt(0).vehicle = companies.ElementAt(2).buses.ElementAt(0);
            //ikinci araç
            companies.ElementAt(2).trips.Add(new Trip());
            companies.ElementAt(2).trips.ElementAt(1).tpTrips.AddRange(defaultTrips.ElementAt(4).tpTrips);
            companies.ElementAt(2).trips.ElementAt(1).Name = defaultTrips.ElementAt(4).Name;
            companies.ElementAt(2).trips.ElementAt(1).vehicle = companies.ElementAt(2).airplanes.ElementAt(0);
            //üçüncü araç
            companies.ElementAt(2).trips.Add(new Trip());
            companies.ElementAt(2).trips.ElementAt(2).tpTrips.AddRange(defaultTrips.ElementAt(4).tpTrips);
            companies.ElementAt(2).trips.ElementAt(2).Name = defaultTrips.ElementAt(4).Name;
            companies.ElementAt(2).trips.ElementAt(2).vehicle = companies.ElementAt(2).airplanes.ElementAt(1);


            //firma D
            companies.ElementAt(3).trains.Add(new Train()
            {
                ID = "Tren1",
                Fuel = "Elektrik",
                Capacity = 25
            });
            companies.ElementAt(3).trains.Last().RandomSeatsAtCapacity();
            companies.ElementAt(3).trains.Add(new Train()
            {
                ID = "Tren2",
                Fuel = "Elektrik",
                Capacity = 25
            });
            companies.ElementAt(3).trains.Last().RandomSeatsAtCapacity();
            companies.ElementAt(3).trains.Add(new Train()
            {
                ID = "Tren3",
                Fuel = "Elektrik",
                Capacity = 25
            });
            companies.ElementAt(3).trains.Last().RandomSeatsAtCapacity();

            companies.ElementAt(3).trains[0].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(3).trains[0].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(3).trains[0].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(3).trains[0].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            companies.ElementAt(3).trains[1].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(3).trains[1].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(3).trains[1].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(3).trains[1].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            companies.ElementAt(3).trains[2].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(3).trains[2].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(3).trains[2].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(3).trains[2].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            //D trips
            //birinci araç
            companies.ElementAt(3).trips.Add(new Trip());
            companies.ElementAt(3).trips.ElementAt(0).tpTrips.AddRange(defaultTrips.ElementAt(0).tpTrips);
            companies.ElementAt(3).trips.ElementAt(0).Name = defaultTrips.ElementAt(0).Name;
            companies.ElementAt(3).trips.ElementAt(0).vehicle = companies.ElementAt(3).trains.ElementAt(0);
            //ikinci araç
            companies.ElementAt(3).trips.Add(new Trip());
            companies.ElementAt(3).trips.ElementAt(1).tpTrips.AddRange(defaultTrips.ElementAt(1).tpTrips);
            companies.ElementAt(3).trips.ElementAt(1).Name = defaultTrips.ElementAt(1).Name;
            companies.ElementAt(3).trips.ElementAt(1).vehicle = companies.ElementAt(3).trains.ElementAt(1);
            //üçüncü araç
            companies.ElementAt(3).trips.Add(new Trip());
            companies.ElementAt(3).trips.ElementAt(2).tpTrips.AddRange(defaultTrips.ElementAt(1).tpTrips);
            companies.ElementAt(3).trips.ElementAt(2).Name = defaultTrips.ElementAt(1).Name;
            companies.ElementAt(3).trips.ElementAt(2).vehicle = companies.ElementAt(3).trains.ElementAt(2);

            //firma F
            companies.ElementAt(4).airplanes.Add(new Airplane()
            {
                ID = "Uçak1",
                Fuel = "Gaz",
                Capacity = 30
            });
            companies.ElementAt(4).airplanes.Last().RandomSeatsAtCapacity();
            companies.ElementAt(4).airplanes.Add(new Airplane()
            {
                ID = "Uçak2",
                Fuel = "Gaz",
                Capacity = 30
            });
            companies.ElementAt(4).airplanes.Last().RandomSeatsAtCapacity();
            companies.ElementAt(4).airplanes[0].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(4).airplanes[0].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(4).airplanes[0].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(4).airplanes[0].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            companies.ElementAt(4).airplanes[1].personels_driver.Add(new Personel { Ad = "da1", Soyad = "ds1" });
            companies.ElementAt(4).airplanes[1].personels_driver.Add(new Personel { Ad = "da2", Soyad = "ds2" });
            companies.ElementAt(4).airplanes[1].personels_service.Add(new Personel { Ad = "sa1", Soyad = "ss2" });
            companies.ElementAt(4).airplanes[1].personels_service.Add(new Personel { Ad = "sa2", Soyad = "ss2" });
            //Ftrips
            //birinci araç
            companies.ElementAt(4).trips.Add(new Trip());
            companies.ElementAt(4).trips.ElementAt(0).tpTrips.AddRange(defaultTrips.ElementAt(5).tpTrips);
            companies.ElementAt(4).trips.ElementAt(0).Name = defaultTrips.ElementAt(5).Name;
            companies.ElementAt(4).trips.ElementAt(0).vehicle = companies.ElementAt(4).airplanes.ElementAt(0);
            //ikinci araç
            companies.ElementAt(4).trips.Add(new Trip());
            companies.ElementAt(4).trips.ElementAt(1).tpTrips.AddRange(defaultTrips.ElementAt(5).tpTrips);
            companies.ElementAt(4).trips.ElementAt(1).Name = defaultTrips.ElementAt(5).Name;
            companies.ElementAt(4).trips.ElementAt(1).vehicle = companies.ElementAt(4).airplanes.ElementAt(1);

        }



    }
}
