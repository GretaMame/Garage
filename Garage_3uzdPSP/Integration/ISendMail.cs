﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP
{
    interface ISendMail
    {
        void SendMail(string emailAddress, string text);
    }
}