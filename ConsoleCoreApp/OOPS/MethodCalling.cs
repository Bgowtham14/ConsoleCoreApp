using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class MethodCalling
    {
        //Method for Call by Value
        public void CallByValue(int x,int y)
        {
            x = x + 20;
            y = y + 30;
            Console.WriteLine($"X:{x}\tY:{y}");
        }
        //Method for Call by Reference behaviour using ref keyword
        public void CallByRef(ref int x, ref int y) 
        {
            x=x + 20;
            y = y + 30;
            Console.WriteLine($"X:{x}\tY:{y}");
        }
        //Method from Call by refenerce using out Keyword
        public void CallByOutput(int x, int y,out int s,out int m,out int d)
        {
            s = x + y;
            m = x * y;
            d = x / y;
        }
        //Method  for call by Named/Optional arguments
        public void CallByNamedOptional(int id,string fname,string surname="Budati",float salary=50000)
        {
            Console.WriteLine($"Welcome: {fname} {surname}");
            Console.WriteLine($"Id:{id}\tSalary:{salary}");
        }
    }
}
