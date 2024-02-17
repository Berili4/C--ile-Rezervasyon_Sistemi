using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{
    public abstract class User : ILoginable
    {
        public String Kullaniciadi { get; set; }
        public String Sifre { get; set; }


    }
}
