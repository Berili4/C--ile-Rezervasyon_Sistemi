using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{
    public interface ILoginable
    {
         String Kullaniciadi { get; set; }
         String Sifre { get; set; }
    }
}
