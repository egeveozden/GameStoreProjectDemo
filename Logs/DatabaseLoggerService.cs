using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class DatabaseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database logged");
        }
    }
}