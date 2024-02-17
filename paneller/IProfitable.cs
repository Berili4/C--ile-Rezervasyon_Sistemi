using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{
    public interface IProfitable
    {
        int Maliyet { get; set; }
        String FuelPrice_Benzin { get; set; }
        String FuelPrice_Motorin { get; set; }
        String FuelPrice_Elektrik { get; set; }
        String FuelPrice_Gaz { get; set; }


    }
}
