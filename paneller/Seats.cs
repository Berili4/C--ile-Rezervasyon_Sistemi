using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paneller
{   
    public class Seats
    {

        static Random random = new Random();
        public Boolean seatsBool;

        public Seats() 
        {
            seatsBool= randomBoolean();
        }

        static bool randomBoolean()
        {
            bool randomBoolean = (random.Next(2) == 0);
            return randomBoolean;
        }
    }
}
