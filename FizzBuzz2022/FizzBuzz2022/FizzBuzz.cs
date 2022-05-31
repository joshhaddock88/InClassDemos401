using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2022
{
    public class FizzBuzz
    {
        // Need a method which takes a number
        // If divisible only by 3, output "fizz";
        // If divisible only by 5, output "buzz";
        // If divisible by 3 AND 5, output "fizzbuzz";

        public static string Convert( int num )
        {
            if( num % 3 == 0 && num % 5 == 0 )
            {
                return "fizzbuzz";
            }
            if( num % 3 == 0 )
            {
                return "fizz";
            }
            if ( num % 5 == 0 )
            {
                return "buzz";
            }
            return num.ToString();
        }
    }
}
