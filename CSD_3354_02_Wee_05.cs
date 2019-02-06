using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }
        static void MethodA()
        {
            while( Peanut())
            {
                Console.WriteLine("Yeah, I have got it");
            }
        }
        static bool Peanut()
        {
            return true;
        }
        
    }
}
