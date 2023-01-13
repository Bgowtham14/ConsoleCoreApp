using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class SingleTonPattern
    {
        static SingleTonPattern singleton;
        private SingleTonPattern()
        {
            
        }
        public static SingleTonPattern GetObject() 
        {
            return singleton == null ? new SingleTonPattern() : singleton;
        }
        public void Display()
        {
            Console.WriteLine("Display from Singleton Pattern");
        }

    }
}
