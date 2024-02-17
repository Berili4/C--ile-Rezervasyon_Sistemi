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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            this.Hide();//arkadaki formu kapatır.
            admingirisi admin = new admingirisi();
            admin.Show();
        }

        private void btnfirma_Click(object sender, EventArgs e)
        {
            this.Hide();//arkadaki formu kapatır.
            CompanyLogin companyLogin = new CompanyLogin();
            companyLogin.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.ExitThread();
            Application.Exit();
        }

        private void btnbiletal_Click(object sender, EventArgs e)
        {
            this.Hide();
            BiletAl biletAl = new BiletAl();
            biletAl.Show();
        }
    }
}
