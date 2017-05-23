using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParKing.Model
{
    public class TicketData
    {
        public int TicketId { get; set; }
        public String EntryTime { get; set; }
        public String ExitTime { get; set; }
        public double TicketPrice { get; set; }
        public int deleted { get; set; }
    }
}
