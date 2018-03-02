using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam.Services.Client
{
    public class Appointment
    {
        public Appointment(string customerID, DateTimeOffset windowStart, DateTimeOffset windowEnd)
        {
            this.CustomerID = customerID;
            this.WindowStart = windowStart;
            this.WindowEnd = windowEnd;
        }

        public string CustomerID { get; private set; }
        public DateTimeOffset WindowStart { get; private set; }
        public DateTimeOffset WindowEnd { get; private set; }

        public override string ToString()
        {
            return $"{this.CustomerID} {this.WindowStart:MMM/d} ({this.WindowStart:htt} to {this.WindowEnd:htt})";
        }
    }
}
