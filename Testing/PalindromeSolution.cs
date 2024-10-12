using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 9. Palindrome
*/
namespace Testing
{
    public class PalindromeSolution
    {
        public bool IsPalindrome(int x)
        {
            //Initialize
            int numForwards = x;
            int numBackwards = 0;
            int lastDigit = 0;

            //All negatives numbers are NOT palindromes
            if (x<0)
            {
                return false;
            }

            //Get last of forwards
            //Add digit to the end of backwards
            //remove digit from x x/=10

            //While x is not 0, AKA has not had last digit removed
            while (x!=0)
            {
                //Get remainder of modulus 10 for last digit
                lastDigit = x % 10;

                //Multiply backwards by 10 then add last digit
                numBackwards = numBackwards*10 + lastDigit;

                //Remove last digit
                x /= 10;
            }
            return numForwards == numBackwards;
        }
    }
}
