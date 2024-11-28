using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call Methods listed below

            Console.ReadKey();
        }

        public class CNum
        {
            public double x; 
            public double y;

             public static double Addition(double x, double y)
            {
                return x + y;
            }

            public static double Addition(double x, double y, double z)
            {
                return x + y + z; 
            }

            public static double Multiplication(double x, double y)
            { 
                return x * y;
            }

            public static double Multiplication(double x, double y, double z)
            {
                return x * y + y * z;
            }
        }


    }
}
