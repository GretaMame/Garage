﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Integration
{
    class SimpleMailSender : ISendMail
    {
        public void SendMail(string emailAddress, string content)
        {
            Console.WriteLine("Email sent to " + emailAddress);
            Console.WriteLine("Email: \n" + content);
            Debug.WriteLine("Mail sent with " + this.GetType().ToString());
        }
    }
}
