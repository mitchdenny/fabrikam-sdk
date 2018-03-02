using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam.Services.Client
{
    public class AppointmentService : IAppointmentService
    {
        public IEnumerable<Appointment> GetAppointments(string customerID)
        {
            yield return new Appointment();
            yield return new Appointment();
            yield return new Appointment();
        }
    }
}
