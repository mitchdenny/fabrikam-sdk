﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam.Services.Client
{
    public class FabrikamClient
    {
        public T GetService<T>() where T: IFabrikamService
        {
            IFabrikamService service = new AppointmentService();
            return (T)service;
        }
    }
}
