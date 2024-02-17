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
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
            DataGridViewTumSeferlerDoldur();
            comboDoldur();
        }

        private void buttonSeferAra_Click(object sender, EventArgs e)
        {
            //Eğer başlangıç ilk yarıdaysa sadece ilk yarı içinde arama yaptır, varış noktasını ikinci yarıda falan bulmasın
            //eğer ikinci yarıda da varsa onu da yapsın,gerekirse iki tarafa birden arama yapabilsin
            DataGridViewSeferAraDoldur();

        }

        private void buttonTarihGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewTumSeferlerDoldur();
        }

        private void BiletAl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void DataGridViewSeferAraDoldur()
        {
            int tptSayisi;
            List<int> indexKalkis;
            int indexVaris;
            dataGridViewSeferAra.DataSource = null;
            try
            {
                BindingList<object> bindingList = new BindingList<object>();

                foreach (Company company in DB.companies)
                {
                    foreach (Trip trip in company.trips)
                    {
                        int esitMi = DateTime.Compare(dateTimePickerSeferAra.Value.Date, trip.TarihSefer);
                        if (esitMi == 0)
                        {
                            tptSayisi = trip.tpTrips.Count;
                            indexKalkis = trip.tpTrips.Select((item, index) => new { Item = item, Index = index })
                                     .Where(x => x.Item.Start == comboBoxKalkis.Text)
                                     .Select(x => x.Index)
                                     .ToList();
                            foreach(int index in indexKalkis)
                            {
                                if (index != -1)
                                {
                                    List<twoPointTrip> indexVarısSubList = trip.tpTrips.GetRange(index, trip.tpTrips.Count - index);
                                    indexVaris = indexVarısSubList.FindIndex(i => i.End == comboBoxVaris.Text);
                                    int durakSayisi=indexVaris -index+1;
                                    
                                    if (indexVaris != -1)
                                    {
                                            bindingList.Add(new
                                            {
                                                Şirketİsmi = company.Kullaniciadi,
                                                SeferinAracı = trip.vehicle.ID,
                                                KalkışNoktası = trip.tpTrips.ElementAt(index).Start,
                                                VarışNoktası = trip.tpTrips.ElementAt(index+indexVaris).End,
                                                AradakiDurakSayısı = durakSayisi,
                                                DoluKoltukSayısı = trip.vehicle.FullSeats,
                                                BoşKoltukSayısı = trip.vehicle.EmptySeats,
                                            });
                                            BindingSource bindingSource = new BindingSource(bindingList, null);
                                            dataGridViewSeferAra.DataSource = bindingSource;
                                        
                                    }

                                }
                            }
                            
                        }


                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DataGridView güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewTumSeferlerDoldur()
        {
            dataGridViewTumSeferler.DataSource = null;
            try
            {
                BindingList<object> bindingList = new BindingList<object>();

                foreach (Company company in DB.companies)
                {
                   foreach(Trip trip in company.trips)
                    {
                        int esitMi = DateTime.Compare(dateTimePickerTumSeferler.Value.Date, trip.TarihSefer);
                        if (esitMi == 0)
                        {
                            bindingList.Add(new
                            {
                                Şirketİsmi = company.Kullaniciadi,
                                SeferinAracı = trip.vehicle.ID,
                                KalkışNoktası = trip.tpTrips.First().Start,
                                VarışNoktası= trip.tpTrips.Last().End,
                                ToplamDurakSayısı = trip.tpTrips.Count,
                                DoluKoltukSayısı = trip.vehicle.FullSeats,
                                BoşKoltukSayısı = trip.vehicle.EmptySeats,
                            });
                            BindingSource bindingSource = new BindingSource(bindingList, null);
                            dataGridViewTumSeferler.DataSource = bindingSource;
                        }

                        
                    }

                }
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"DataGridView güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboDoldur()
        {
            comboBoxKalkis.Text = String.Empty;
            comboBoxVaris.Text = String.Empty;
            foreach (var item in DB.ray_tum)
            {
                comboBoxKalkis.Items.Add(item);
                comboBoxVaris.Items.Add(item);
            }
        }

        private void dataGridViewSeferAra_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (textBoxYolcuSayisi.Text=="")
            {
                MessageBox.Show("Yolcu sayısı boş bırakılamaz! Bir sayı giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;           
            }
            string strFirma = dataGridViewSeferAra.Rows[e.RowIndex].Cells[0].Value.ToString();
            string strArac = dataGridViewSeferAra.Rows[e.RowIndex].Cells[1].Value.ToString();
            int biletSayisi = int.Parse(textBoxYolcuSayisi.Text);
            DetaylıSeferBilgisi detaylıSeferBilgisi= new DetaylıSeferBilgisi(strFirma,strArac, biletSayisi);
            detaylıSeferBilgisi.Show();
        }
    }
}
