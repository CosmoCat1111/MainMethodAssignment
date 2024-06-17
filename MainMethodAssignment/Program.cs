using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
   class Program
    {
        static void Main(string[] args)
        {
            // calls class
            MathOperations math = new MathOperations();

            // method 1  - integer
            int integerResult = math.MathOp(15);
            Console.WriteLine("Result of integer operation: " + integerResult);
            Console.ReadLine();

            //method 2 - decimal
            decimal decimalValue = 7.5m;
            int decimalResult = math.MathOp(decimalValue);
            Console.WriteLine("Result of decimal operation: " + decimalResult);
            Console.ReadLine();

            // method 3 - string
            string inputString = "50";
            int stringResult = Convert.ToInt32(inputString);
            Console.WriteLine("Result of string Operation is " + stringResult);
            Console.ReadLine();

            //exception handling
            string invalidInput = "abc";
            try
            {
                string invalidResult = Convert.ToString(invalidInput);
                Console.WriteLine("Invalid String results are " + invalidInput);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error, please enter integer:");
                //Console.ReadLine();
            }
            Console.ReadLine();
        }
    }

}
