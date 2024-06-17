using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{

    public class MathOperations
    {
        // Method 1 -- addition
        public int MathOp(int number)
        {
            int result = number + 10;
            return result;
        }

        // Method 2 - multiply
        public int MathOp(decimal number)
        {
            int result = (int)(number * 2);
            return result;
        }

        // Method 3 - division 
        public int MathOP(string input)
        {
            if (int.TryParse(input, out int number))
            {
                int result = number / 5;
                return result;
            }
            else
            {
                throw new ArgumentException("Not valid, please enter an integer:");
                Console.ReadLine();
            }

        }

    }

}
