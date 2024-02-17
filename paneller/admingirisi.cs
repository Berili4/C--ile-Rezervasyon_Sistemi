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
    public partial class admingirisi : Form
    {
        public admingirisi()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if(textkullaniciadi.Text=="admin" && textsifre.Text =="admin")
            {
                this.Hide();
                Adminpaneli adminpaneli = new Adminpaneli();
                adminpaneli.Show();

            }
            else
            {
                MessageBox.Show("Hatalı admin bilgisi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void admingirisi_Load(object sender, EventArgs e)
        {
            
        }

        private void admingirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }
    }
}
