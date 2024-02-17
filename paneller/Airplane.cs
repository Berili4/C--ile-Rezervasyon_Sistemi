using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{
    public class Airplane : Vehicle
    {
        public Airplane() { }
        public override Vehicle AddVehicle(string Start,string End)
        {
            Airplane airplane = new Airplane();
            return airplane;
        }

    }
}
