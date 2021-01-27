using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class SmsLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms logged");
        }
    }
}
