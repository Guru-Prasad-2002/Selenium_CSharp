using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rahul_Shetty_C__Fundamentals
{
    class Data_types
    {
        public static void data_types_func()
        {
            int a = 10;
            //using concat operator print a
            Console.WriteLine("Value of a is "+ a);
            //Print using eval string
            Console.Write($"Value of a is {a}");

            string name = "Guru";
            Console.WriteLine($"Your name is {name}");

            //var - used when we are not sure abnout the type
            // var - once type is decide it cannot be changed

            var b = "Sup";
            Console.WriteLine($"Value of b is {b}");
            //b=10 -> will throw an error

            //dynamic - type can be changed, similar to python

            dynamic d = "Prasad";
            Console.WriteLine($"First Value of the dynamic variable d {d}");
            d = 10;
            Console.WriteLine($"Value of dynamic variable d after changing the type {d}");

        }



    }
}
