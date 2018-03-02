using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam.Services.Client.CommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Customer ID: ");
            var customerID = Console.ReadLine();

            var client = new FabrikamClient();
            var service = client.GetService<IAppointmentService>();
            var appointments = service.GetAppointments(customerID);

            foreach (var appointment in appointments)
            {
                Console.WriteLine(appointment);
            }

        }
    }
}
