using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParKing.Model
{
    public class ParkingPlaceData
    {
        public int id { get; set; }
        public String Name { get; set; }
        public int numberOfParkingSlots { get; set; }
        public double pricePerHour { get; set; }
        public int deleted { get; set; }
    }
}
