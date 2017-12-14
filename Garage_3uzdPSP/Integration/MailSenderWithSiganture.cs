using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Integration
{
    class MailSenderWithSiganture : Integration.ISendMail
    {
        public void SendMail(string emailAddress, string content)
        {
            string signature = "\nKind Regards";
            Console.WriteLine("Email sent to " + emailAddress);
            Console.WriteLine("Email: \n" + content + "\n" + signature);
            Debug.WriteLine("Mail sent with " + this.GetType().ToString());
        }
    }
}
