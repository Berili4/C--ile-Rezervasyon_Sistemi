using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paneller
{
    public partial class DetaylıSeferBilgisi : Form
    {
        static int gelenbiletSayisi;
        static String FirmaAdi;
        static String AracAdi;
        static int indexFirma;
        static int indexTrip;
        public DetaylıSeferBilgisi(String strFirma,String strArac, int yolcuSayisi)
        {
            gelenbiletSayisi = yolcuSayisi;
            FirmaAdi = strFirma;
            AracAdi = strArac;
            indexFirma = DB.companies.FindIndex(i => i.Kullaniciadi == FirmaAdi);
            indexTrip = DB.companies.ElementAt(indexFirma).trips.FindIndex(i => i.vehicle.ID == strArac);
            InitializeComponent();
            DataGridViewDoldur();
            comboYolcuDoldur();
            comboKoltukSecDoldur();
        }

        private void DataGridViewDoldur()
        {
            dataGridViewKoltuk.DataSource = null;

            try
            {
                BindingList<object> bindingList = new BindingList<object>();

                foreach (Seats seats in DB.companies.ElementAt(indexFirma).trips.ElementAt(indexTrip).vehicle.seatsList)
                {
                    bindingList.Add(new
                    {
                        KoltukNumarası = DB.companies.ElementAt(indexFirma).trips.ElementAt(indexTrip).vehicle.seatsList.IndexOf(seats)+1,
                        DolulukDurumu = seats.seatsBool
                    });
                }
                    BindingSource bindingSource = new BindingSource(bindingList, null);
                    dataGridViewKoltuk.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DataGridView güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboYolcuDoldur()
        {
            for (int i = 0;i< gelenbiletSayisi;i++)
            {
                comboYolcu.Items.Add("Yolcu "+(i+1));
            }
        }

        private void comboKoltukSecDoldur()
        {
            int koltukSayisi = DB.companies.ElementAt(indexFirma).trips.ElementAt(indexTrip).vehicle.seatsList.Count;
            for (int i = 0; i < koltukSayisi; i++)
            {
                comboKoltukSec.Items.Add(i+1);
            }
        }

        private void buttonSatınAl_Click(object sender, EventArgs e)
        {
            int olduMu = DB.companies.ElementAt(indexFirma).trips.ElementAt(indexTrip).vehicle.BirKoltukDoldur(int.Parse(comboKoltukSec.Text)-1);
            if(olduMu == -1)
            {
                MessageBox.Show("Bilet alınamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rezerveEt();
            DataGridViewDoldur();
        }

        private void rezerveEt()
        {
            Reservation.reservations.Add(new Reservation.Info()
            {
                biletSayisi = gelenbiletSayisi,
                firma = DB.companies.ElementAt(indexFirma),
                arac = DB.companies.ElementAt(indexFirma).trips.ElementAt(indexTrip).vehicle,
                isim = textBoxİsim.Text,
                soyisim = textBoxSoyisim.Text,
                koltukNumarası = comboKoltukSec.SelectedIndex,
                TCNumarası = textBoxTC.Text

            });
            MessageBox.Show("Bilet alındı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
