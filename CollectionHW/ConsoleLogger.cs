using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHW
{
    public class ConsoleLogger : ILogger
    {
        public void Log(Exception e)
        {
            Console.WriteLine(e);
            
        }
    }
}
