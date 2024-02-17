using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{
    public class Admin : User
    {
        public Admin(String Kullaniciadi,String Sifre)
        {
            this.Kullaniciadi = Kullaniciadi;
            this.Sifre = Sifre;
        }
    }
}
