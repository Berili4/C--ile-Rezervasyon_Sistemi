using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace paneller
{
    public partial class CompanyPanel : Form
    {
        int indexgirenfirma = 0;
        int indexcomboVehicles = 0;
        int indexseferBasBit = 0;
        String strcomboBasNok;
        String strcomboBitNok;
        String strcomboseferaracekle;

        public CompanyPanel(int _indexgirenfirma)
        {
            InitializeComponent();
            indexgirenfirma = _indexgirenfirma;
        }

        private void btnaracekle_Click(object sender, EventArgs e)
        {
            if (textBoxCapacity.Text == null) { return; }
            int indexAyniİsim;
            if (textBoxaracisim.Text.StartsWith(comboBoxVehicles.Text))
            {
                String Fuel = textBoxFuel.Text;
                if (indexcomboVehicles == 0)
                {
                    indexAyniİsim = DB.companies.ElementAt(indexgirenfirma).buses.FindIndex(i => i.ID == textBoxaracisim.Text);
                    if (indexAyniİsim >= 0)
                    {
                        MessageBox.Show("Aynı isimde başka bir araç bulunmaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Fuel == "Benzin" || Fuel == "Motorin")
                    {
                        DB.companies.ElementAt(indexgirenfirma).buses.Add
                            (new Bus()
                            {
                                Fuel = textBoxFuel.Text,
                                ID = textBoxaracisim.Text,
                                Capacity = int.Parse(textBoxCapacity.Text)
                            }
                            );
                        DB.companies.ElementAt(indexgirenfirma).buses.Last().RandomSeatsAtCapacity();
                        DB.companies[indexgirenfirma].trips.Add(new Trip()
                        {
                            vehicle = DB.companies.ElementAt(indexgirenfirma).buses.Last()
                        }
                        );
                        comboSilinecekAracDoldur();
                        comboSilinecekSeferDoldur();
                        MessageBox.Show("Araç başarıyla eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Yakıt türü sadece \"Benzin\" veya \"Motorin\" olabilir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                if (indexcomboVehicles == 1)
                {
                    indexAyniİsim = DB.companies.ElementAt(indexgirenfirma).trains.FindIndex(i => i.ID == textBoxaracisim.Text);
                    if (indexAyniİsim >= 0)
                    {
                        MessageBox.Show("Aynı isimde başka bir araç bulunmaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DB.companies.ElementAt(indexgirenfirma).trains.Add
                        (new Train()
                        {
                            Fuel = "Elektrik",
                            ID = textBoxaracisim.Text,
                            Capacity = int.Parse(textBoxCapacity.Text)
                        }
                        );
                    DB.companies.ElementAt(indexgirenfirma).trains.Last().RandomSeatsAtCapacity();
                    DB.companies[indexgirenfirma].trips.Add(new Trip()
                    {
                        vehicle = DB.companies.ElementAt(indexgirenfirma).trains.Last()
                    }
                        );
                    comboSilinecekAracDoldur();
                    comboSilinecekSeferDoldur();
                    MessageBox.Show("Araç başarıyla eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (indexcomboVehicles == 2)
                {
                    indexAyniİsim = DB.companies.ElementAt(indexgirenfirma).airplanes.FindIndex(i => i.ID == textBoxaracisim.Text);
                    if (indexAyniİsim >= 0)
                    {
                        MessageBox.Show("Aynı isimde başka bir araç bulunmaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DB.companies.ElementAt(indexgirenfirma).airplanes.Add
                        (new Airplane()
                        {
                            Fuel = "Gaz",
                            ID = textBoxaracisim.Text,
                            Capacity = int.Parse(textBoxCapacity.Text)
                        }
                        );
                    DB.companies.ElementAt(indexgirenfirma).airplanes.Last().RandomSeatsAtCapacity();
                    DB.companies[indexgirenfirma].trips.Add(new Trip()
                    {
                        vehicle = DB.companies.ElementAt(indexgirenfirma).airplanes.Last()
                    }
                        );
                    comboSilinecekAracDoldur();
                    comboSilinecekSeferDoldur();
                    MessageBox.Show("Araç başarıyla eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                comboseferaracekle.Items.Clear();
                comboSeferAracEkleDoldur();
            }
            else
            {
                MessageBox.Show("Araç ismi seçilen araç türüyle başlamalıdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxaracisim.Text = String.Empty;
            }

        }

        private void comboBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexcomboVehicles = comboBoxVehicles.SelectedIndex;
            if (indexcomboVehicles == 0)
                textBoxFuel.Enabled = true;
            if (indexcomboVehicles == 1)
            {
                textBoxFuel.Enabled = false;
                textBoxFuel.Text = String.Empty;
            }

            if (indexcomboVehicles == 2)
            {
                textBoxFuel.Enabled = false;
                textBoxFuel.Text = String.Empty;
            }
        }

        private void comboBoxAracTipiDoldur()
        {
            foreach (var item in DB.vehiclesCombo)
            {
                comboBoxVehicles.Items.Add(item);
            }
        }

        private void CompanyPanel_Load(object sender, EventArgs e)
        {
            comboBoxAracTipiDoldur();
            DataGridViewDoldur();
            comboSeferAracEkleDoldur();
            comboSilinecekAracDoldur();
            comboSilinecekSeferDoldur();

        }


        private void DataGridViewDoldur()
        {
            try
            {
                BindingList<object> bindingList = new BindingList<object>();

                foreach (Trip trip in DB.companies.ElementAt(indexgirenfirma).trips)
                {
                    if (trip.tpTrips.Count != 0)
                    {
                        bindingList.Add(new
                        {
                            SeferinAracı = trip.vehicle.ID,
                            SeferTarihi = trip.TarihSefer,
                            SeferDoluKoltuk = trip.vehicle.FullSeats,
                            SeferBoşKoltuk = trip.vehicle.EmptySeats,
                            İlkDurak = trip.tpTrips.First().Start,
                            SonDurak = trip.tpTrips.Last().End,
                            DurakSayısı = trip.tpTrips.Count(),
                            SeyahatMaliyeti = trip.price
                        });

                        BindingSource bindingSource = new BindingSource(bindingList, null);
                        dataGridViewaracsefer.DataSource = bindingSource;
                    }
                    else
                        continue;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DataGridView güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompanyPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            CompanyLogin companyLogin = new CompanyLogin();
            companyLogin.ShowDialog();

        }

        private void comboseferaracekle_SelectedValueChanged(object sender, EventArgs e)
        {
            strcomboseferaracekle = comboseferaracekle.Text;

            combobasnok.Text = String.Empty;
            combobitnok.Text = String.Empty;
            comboBasNokDoldur();

        }

        private void combobasnok_SelectedValueChanged(object sender, EventArgs e)
        {
            strcomboBasNok = combobasnok.Text;
            comboBitNokDoldur();
        }

        private void combobitnok_SelectedValueChanged(object sender, EventArgs e)
        {
            strcomboBitNok = combobitnok.Text;
        }



        private void comboSeferAracEkleDoldur()
        {
            comboseferaracekle.Text = String.Empty;
            comboseferaracekle.Items.Clear();
            foreach (var item in DB.companies.ElementAt(indexgirenfirma).buses)
            {
                comboseferaracekle.Items.Add(item);
            }

            foreach (var item in DB.companies.ElementAt(indexgirenfirma).trains)
            {
                comboseferaracekle.Items.Add(item);
            }

            foreach (var item in DB.companies.ElementAt(indexgirenfirma).airplanes)
            {
                comboseferaracekle.Items.Add(item);
            }
        }

        private void comboBasNokDoldur()
        {
            combobasnok.Items.Clear();
            Boolean boolSeferiBulduMu = false;
            int indexTrip = 0;
            while (!boolSeferiBulduMu)
            {
                if (DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).vehicle.ID == strcomboseferaracekle)
                {
                    boolSeferiBulduMu = true;
                    break;
                }
                indexTrip++;
            }
            if (DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).tpTrips.Count != 0)
                combobasnok.Items.Add(DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).tpTrips.Last().End);
            else
                boolSeferiBulduMu = false;


            if (DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).tpTrips.Count == 0)
            {
                if (strcomboseferaracekle.ToLower().StartsWith("oto"))
                {
                    foreach (var item in DB.kara_tum)
                        combobasnok.Items.Add(item);
                }

                if (strcomboseferaracekle.ToLower().StartsWith("tr"))
                {
                    foreach (var item in DB.ray_tum)
                        combobasnok.Items.Add(item);
                }

                if (strcomboseferaracekle.ToLower().StartsWith("uç"))
                {
                    foreach (var item in DB.hava_tum)
                        combobasnok.Items.Add(item);
                }
            }
        }

        #region
        private void comboBitNokDoldur()
        {
            combobitnok.Items.Clear();
            if (strcomboseferaracekle.ToLower().StartsWith("oto"))
            {
                if (strcomboBasNok.Equals("İstanbul"))
                {
                    foreach (var item in DB.kara_ist)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Kocaeli"))
                {
                    foreach (var item in DB.kara_koc)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Ankara"))
                {
                    foreach (var item in DB.kara_ank)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Eskişehir"))
                {
                    foreach (var item in DB.kara_esk)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Konya"))
                {
                    foreach (var item in DB.kara_kon)
                        combobitnok.Items.Add(item);
                }
            }

            if (strcomboseferaracekle.ToLower().StartsWith("tr"))
            {
                if (strcomboBasNok.Equals("İstanbul"))
                {
                    foreach (var item in DB.ray_ist)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Kocaeli"))
                {
                    foreach (var item in DB.ray_koc)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Bilecik"))
                {
                    foreach (var item in DB.ray_bil)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Ankara"))
                {
                    foreach (var item in DB.ray_ank)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Eskişehir"))
                {
                    foreach (var item in DB.ray_esk)
                        combobitnok.Items.Add(item);
                }
                else if (strcomboBasNok.Equals("Konya"))
                {
                    foreach (var item in DB.ray_kon)
                        combobitnok.Items.Add(item);
                }
            }

            if (strcomboseferaracekle.ToLower().StartsWith("uç"))
            {
                if (strcomboBasNok.Equals("İstanbul"))
                {
                    foreach (var item in DB.hava_ist)
                        combobitnok.Items.Add(item);
                }

                else if (strcomboBasNok.Equals("Ankara"))
                {
                    foreach (var item in DB.hava_ank)
                        combobitnok.Items.Add(item);
                }

                else if (strcomboBasNok.Equals("Konya"))
                {
                    foreach (var item in DB.hava_kon)
                        combobitnok.Items.Add(item);
                }
            }

        }
        #endregion


        private void btnyenidurakekle_Click(object sender, EventArgs e)
        {   //bas, bit ve arac bossa durak eklemesin 
            if (combobasnok.Text.Length == 0 || combobitnok.Text.Length == 0 || comboseferaracekle.Text.Length == 0)
            {
                MessageBox.Show("Araç, başlangıç ve bitiş kutucukları dolu olmalıdır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean boolSeferiBulduMu = false;
                int indexTrip = 0;
                if (strcomboseferaracekle.ToLower().StartsWith("oto"))
                    indexseferBasBit = DB.stopsLand.FindIndex(i => i.Start == strcomboBasNok && i.End == strcomboBitNok);
                if (strcomboseferaracekle.ToLower().StartsWith("tr"))
                    indexseferBasBit = DB.stopsRail.FindIndex(i => i.Start == strcomboBasNok && i.End == strcomboBitNok);
                if (strcomboseferaracekle.ToLower().StartsWith("uç"))
                    indexseferBasBit = DB.stopsAir.FindIndex(i => i.Start == strcomboBasNok && i.End == strcomboBitNok);
                while (!boolSeferiBulduMu)
                {
                    if (DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).vehicle.ID == strcomboseferaracekle)
                    {
                        boolSeferiBulduMu = true;
                        break;
                    }
                    indexTrip++;
                }
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).vehicle.RandomSeatsAtCapacity();
                sefereDurakEkle(indexTrip);
            }
        }

        public void sefereDurakEkle(int indexTrip)
        {
            if (strcomboseferaracekle.ToLower().StartsWith("oto"))
            {
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).tpTrips.Add(new twoPointTrip()
                {
                    Start = DB.stopsLand.ElementAt(indexseferBasBit).Start,
                    End = DB.stopsLand.ElementAt(indexseferBasBit).End,
                    Distance = DB.stopsLand.ElementAt(indexseferBasBit).Distance

                }
            );
            }
            if (strcomboseferaracekle.ToLower().StartsWith("tr"))
            {
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).tpTrips.Add(new twoPointTrip()
                {
                    Start = DB.stopsRail.ElementAt(indexseferBasBit).Start,
                    End = DB.stopsRail.ElementAt(indexseferBasBit).End,
                    Distance = DB.stopsRail.ElementAt(indexseferBasBit).Distance

                }
            );
            }
            if (strcomboseferaracekle.ToLower().StartsWith("uç"))
            {
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).tpTrips.Add(new twoPointTrip()
                {
                    Start = DB.stopsAir.ElementAt(indexseferBasBit).Start,
                    End = DB.stopsAir.ElementAt(indexseferBasBit).End,
                    Distance = DB.stopsAir.ElementAt(indexseferBasBit).Distance

                }
            );
            }

            DataGridViewDoldur();
            comboBasNokDoldur();
            comboBitNokDoldur();
            combobasnok.Text = String.Empty;
            combobitnok.Text = String.Empty;
        }

        private void comboSilinecekAracDoldur()
        {
            comboSilinecekArac.Items.Clear();
            foreach (var item in DB.companies.ElementAt(indexgirenfirma).buses)
            {
                comboSilinecekArac.Items.Add(item);
            }

            foreach (var item in DB.companies.ElementAt(indexgirenfirma).trains)
            {
                comboSilinecekArac.Items.Add(item);
            }

            foreach (var item in DB.companies.ElementAt(indexgirenfirma).airplanes)
            {
                comboSilinecekArac.Items.Add(item);
            }
        }

        private void comboSilinecekSeferDoldur()
        {
            comboSilinecekSefer.Text = String.Empty;
            comboSilinecekSefer.Items.Clear();
            foreach (var item in DB.companies.ElementAt(indexgirenfirma).buses)
            {
                comboSilinecekSefer.Items.Add(item);
            }

            foreach (var item in DB.companies.ElementAt(indexgirenfirma).trains)
            {
                comboSilinecekSefer.Items.Add(item);
            }

            foreach (var item in DB.companies.ElementAt(indexgirenfirma).airplanes)
            {
                comboSilinecekSefer.Items.Add(item);
            }

            DataGridViewDoldur();
        }

        private void btnaracsil_Click(object sender, EventArgs e)
        {
            int indexsilarac;
            int indexsiltrip;//!!!!!!!!
            if (comboSilinecekArac.Text.Length == 0)
            {
                MessageBox.Show("Bir araç seçiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboSilinecekArac.Text.ToLower().StartsWith("oto"))
                {
                    indexsilarac = DB.companies.ElementAt(indexgirenfirma).buses.FindIndex(i => i.ID == comboSilinecekArac.Text);
                    DB.companies.ElementAt(indexgirenfirma).buses.RemoveAt(indexsilarac);
                    indexsiltrip = DB.companies.ElementAt(indexgirenfirma).trips.FindIndex(i => i.vehicle.ID == comboSilinecekArac.Text);
                    DB.companies.ElementAt(indexgirenfirma).trips.RemoveAt(indexsiltrip);
                }
                if (comboSilinecekArac.Text.ToLower().StartsWith("tr"))
                {
                    indexsilarac = DB.companies.ElementAt(indexgirenfirma).trains.FindIndex(i => i.ID == comboSilinecekArac.Text);
                    DB.companies.ElementAt(indexgirenfirma).trains.RemoveAt(indexsilarac);
                    indexsiltrip = DB.companies.ElementAt(indexgirenfirma).trips.FindIndex(i => i.vehicle.ID == comboSilinecekArac.Text);
                    DB.companies.ElementAt(indexgirenfirma).trips.RemoveAt(indexsiltrip);
                }
                if (comboSilinecekArac.Text.ToLower().StartsWith("uç"))
                {
                    indexsilarac = DB.companies.ElementAt(indexgirenfirma).airplanes.FindIndex(i => i.ID == comboSilinecekArac.Text);
                    DB.companies.ElementAt(indexgirenfirma).airplanes.RemoveAt(indexsilarac);
                    indexsiltrip = DB.companies.ElementAt(indexgirenfirma).trips.FindIndex(i => i.vehicle.ID == comboSilinecekArac.Text);
                    DB.companies.ElementAt(indexgirenfirma).trips.RemoveAt(indexsiltrip);
                }
                MessageBox.Show("Araç silinmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboSilinecekArac.Text = String.Empty;
                comboSilinecekAracDoldur();
                comboSilinecekSeferDoldur();
                comboSeferAracEkleDoldur();
                DataGridViewDoldur();
            }
        }


        private void btnsefersil_Click(object sender, EventArgs e)
        {
            int indexsiltrip = 0;
            if (comboSilinecekSefer.Text.ToLower().StartsWith("oto"))
            {
                indexsiltrip = DB.companies.ElementAt(indexgirenfirma).trips.FindIndex(i => i.vehicle.ID == comboSilinecekSefer.Text);
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexsiltrip).tpTrips.Clear();
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexsiltrip).vehicle.RandomSeatsAtCapacity();
            }
            if (comboSilinecekSefer.Text.ToLower().StartsWith("tr"))
            {
                indexsiltrip = DB.companies.ElementAt(indexgirenfirma).trips.FindIndex(i => i.vehicle.ID == comboSilinecekSefer.Text);
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexsiltrip).tpTrips.Clear();
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexsiltrip).vehicle.RandomSeatsAtCapacity();
            }
            if (comboSilinecekSefer.Text.ToLower().StartsWith("uç"))
            {
                indexsiltrip = DB.companies.ElementAt(indexgirenfirma).trips.FindIndex(i => i.vehicle.ID == comboSilinecekSefer.Text);
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexsiltrip).tpTrips.Clear();
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexsiltrip).vehicle.RandomSeatsAtCapacity();
            }
            MessageBox.Show("Sefer silinmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboSilinecekAracDoldur();
            comboSilinecekSeferDoldur();
            comboSeferAracEkleDoldur();
            DataGridViewDoldur();
            combobasnok.Items.Clear();
            combobitnok.Items.Clear();
        }

        private void buttonSeferTarihiGuncelle_Click(object sender, EventArgs e)
        {
            if (comboseferaracekle.Text.Length == 0)
            {
                MessageBox.Show("Araç kutucuğu dolu olmalıdır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean boolSeferiBulduMu = false;
                int indexTrip = 0;
                while (!boolSeferiBulduMu)
                {
                    if (DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).vehicle.ID == strcomboseferaracekle)
                    {
                        boolSeferiBulduMu = true;
                        break;
                    }
                    indexTrip++;
                }
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).TarihSefer = dateTimePickerSeferTarihi.Value.Date;
                MessageBox.Show("Sefer tarihi güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.companies.ElementAt(indexgirenfirma).trips.ElementAt(indexTrip).vehicle.RandomSeatsAtCapacity();
                DataGridViewDoldur();
                comboseferaracekle.Text = string.Empty;

            }

        }
    }
}
