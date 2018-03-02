using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fabrikam.Services.Client.Tests
{
    [TestClass]
    public class FabrikamClientTest
    {
        [TestMethod]
        public void Canary()
        {
            var client = new FabrikamClient();
            var appointmentService = client.GetService<IAppointmentService>();
        }
    }
}
