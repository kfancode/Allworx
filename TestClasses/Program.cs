using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllworxLib;

namespace TestClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AllworxCall c = new AllworxCall("12/08/14,09:31 AM,Incoming Toll Free,(800) 742-3763,(401) 270-0618,2.0,$0.0400,$0.08,0");
            Console.WriteLine(c.GetCall());
        
            Console.WriteLine("From:  " + c.GetFrom() + "\nTo:  " + c.GetTo());
            Console.ReadLine();
        }
    }
}
