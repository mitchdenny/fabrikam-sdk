using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam.Services.Client
{
    public interface IAppointmentService : IFabrikamService
    {
        IEnumerable<Appointment> GetAppointments(string customerID);
    }
}
