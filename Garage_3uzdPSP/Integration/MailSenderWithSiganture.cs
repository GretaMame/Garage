using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Integration
{
    class MailSenderWithSiganture : ISendMail
    {
        string Signature { get; set; }

        public MailSenderWithSiganture(string signature)
        {
            Signature = signature;
        }

        public void SendMail(string emailAddress, string content)
        {
            Console.WriteLine("Email sent to " + emailAddress);
            Console.WriteLine("Email: \n" + content + "\n" + Signature);
            Debug.WriteLine("Mail sent with " + this.GetType().ToString());
        }
    }
}
