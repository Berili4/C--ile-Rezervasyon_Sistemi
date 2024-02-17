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
    public partial class CompanyLogin : Form
    {
        public CompanyLogin()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string girenFirmaİsim = textkullaniciadi.Text;
            string girenFirmaSifre = textsifre.Text;
            int indexgirenfirma = DB.companies.FindIndex(i => i.Kullaniciadi == girenFirmaİsim);
            if(indexgirenfirma > -1)
            {
                if (DB.companies.ElementAt(indexgirenfirma).Sifre == girenFirmaSifre)
                {
                    this.Hide();
                    CompanyPanel companyPanel = new CompanyPanel(indexgirenfirma);
                    companyPanel.Show();
                }
                else
                {
                    MessageBox.Show("Şifre Hatalı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Bu isimde bir firma bulunmamakta.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CompanyLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
