using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class StaticDemo
    {
        int id; //non-static data field
        static int count;   //static data field
        public StaticDemo()
        {
            this.id = count++; 
        }
        public void DisplayId()
        {
            Console.WriteLine($"ID:{id}");
        }
        public static void DisplayCount() //it can only access with class name
        {
            Console.WriteLine($"Object Count Created:{count}");
        }
        static StaticDemo()
        {
            count = 0;
        }
    }
}
