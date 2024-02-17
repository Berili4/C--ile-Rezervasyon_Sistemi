using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace paneller
{
    public partial class Adminpaneli : Form
    {
        public Adminpaneli()
        {
            InitializeComponent();
        }

        private void Adminpaneli_Load(object sender, EventArgs e)
        {
            listboxdoldur();
        }

        void listboxdoldur()
        {
            foreach (var item in DB.companies )
            {
                Firmalar.Items.Add( item );
            }
        }
        
        void listboxtemizle()
        {
            Firmalar.Items.Clear();
        }

        private void btnfirmakayit_Click(object sender, EventArgs e)
        {

        }

        private void Firmalar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnfirmasil_Click(object sender, EventArgs e)
        {
            string silinecekFirma = textBoxfirmasil.Text;
            int silFirIndex = DB.companies.FindIndex(i=> i.Kullaniciadi == silinecekFirma );
            if( silFirIndex < 0 )
            {
                MessageBox.Show("Silinecek Firma Kayıtlı Değil!","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                DB.companies.RemoveAt(silFirIndex);
                listboxtemizle();
                listboxdoldur();
            }
            

        }

        private void btnfirmaekle_Click(object sender, EventArgs e)
        {
            string eklenecekFirma = textBoxkullaniciadi.Text;
            int ekleFirIndex = DB.companies.FindIndex(i => i.Kullaniciadi == eklenecekFirma);
            if (ekleFirIndex < 0)
            {

                DB.companies.Add(new Company()
                {
                    Kullaniciadi = textBoxkullaniciadi.Text,
                    Sifre = textBoxsifre.Text
                });
                listboxtemizle();
                listboxdoldur();
            }
            else
            {
                MessageBox.Show("Bu firma ismi kullanılıyor! Yeni bir isim seçiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnhizmetbedel_Click(object sender, EventArgs e)
        {
            DB.hizmetBedeli= int.Parse(textBoxhizmetbedel.Text) ;
            MessageBox.Show("Hizmet bedeli güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Adminpaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
