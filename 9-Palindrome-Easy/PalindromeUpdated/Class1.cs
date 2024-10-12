using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeUpdated
{
    internal class Class1
    {
        public bool IsPalindrome(int x)
        {
            // Initialize
            int numForwards = x;
            int numBackwards = 0;

            // All negatives are false
            if (x < 0)
            {
                return false;
            }

            //Get the last digit of x 
                //To get the last digit of x, modulus by 10, the remainder will be the ones column
            //Increasingly add the remainders to the backwards num
                //Multiply numBackwards by 10 to free the ones column, then add remainder
            //Take off last digit from x
                //Dividing any INT by 10 causes decimal to be lost

            //Do all this while x !=0
                //Once x = 0, no more digits left (following /=10 removes digit logic)


        }
    }
}
