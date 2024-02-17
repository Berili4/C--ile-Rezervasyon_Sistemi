using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paneller
{
    public abstract class Vehicle
    {
        //koltuklara yeni class
        public String ID;
        public String Fuel;
        public int Capacity;
        public List<Personel> personels_driver;
        public List<Personel> personels_service;
        public List<Seats> seatsList;
        public int FullSeats;
        public int EmptySeats;
        public Vehicle()
        {
            int cap = Capacity;
        personels_driver= new List<Personel>();
        personels_service= new List<Personel>();
        seatsList = new List<Seats>();
        
        RandomSeatsAtCapacity();
        }

        public abstract Vehicle AddVehicle(string Start, string End);

        public void RandomSeatsAtCapacity()
        {
            seatsList.Clear();
            for (int i = 0; i < Capacity; i++)
            {
                seatsList.Add(new Seats());
            }
            SeatCounter();
        }

        private void SeatCounter()
        {
            FullSeats = 0;
            EmptySeats = 0;
            foreach(Seats seats in seatsList)
            {
                if(seats.seatsBool==true)
                {
                    FullSeats++;
                }
                else
                {
                    EmptySeats++;
                }
            }
        }

        public int CalculateFuelCost()
        {

            return 0;
        }

        public override string ToString()
        {
            return ID;
        }

        public int BirKoltukDoldur(int indexKoltuk)
        {
            if (seatsList[indexKoltuk].seatsBool==true)
            {
                MessageBox.Show("Seçtiğiniz koltuk dolu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            FullSeats++;
            EmptySeats--;
            seatsList[indexKoltuk].seatsBool = true;
            return 1;
        }

    }
}
