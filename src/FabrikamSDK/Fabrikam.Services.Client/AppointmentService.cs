using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam.Services.Client
{
    public class AppointmentService : IAppointmentService
    {
        private Random random = new Random();

        private Appointment GenerateSampleAppointment(string customerID)
        {
            var windowDate = DateTimeOffset.Now.Date.AddDays(random.Next(30));
            var windowStart = windowDate.AddHours(8 + random.Next(4));
            var windowEnd = windowStart.AddHours(2 + random.Next(2));

            var appointment = new Appointment(customerID, windowStart, windowEnd);
            return appointment;
        }

        public IEnumerable<Appointment> GetAppointments(string customerID)
        {
            yield return GenerateSampleAppointment(customerID);
            yield return GenerateSampleAppointment(customerID);
            yield return GenerateSampleAppointment(customerID);
        }
    }
}
