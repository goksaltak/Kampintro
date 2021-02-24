using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MailLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Mail Gönderildi.");
        }
    }
}
