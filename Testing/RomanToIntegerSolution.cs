using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 13. Roman to Integer
*/
namespace Testing
{
    public class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            /*
             I             1
             V             5
             X             10
             L             50
             C             100
             D             500
             M             1000  
             
            ***Exceptions!***
            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.

            !Hint!
            Got right to left using a map(Dictionary)
             */

            //Map
            var romanToIntMap = new Dictionary<char, int>()
            {
                {'I' , 1 },
                {'V' , 5 },
                {'X' , 10},
                {'L' , 50},
                {'C' , 100},
                {'D' , 500},
                {'M' , 1000}
            };

            var total = 0;
            var lastNum = 0;

            //cut the string
            //iterate through right to left
            //if the number to t

            //Reverse iteration
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //Current numeral as key to get value int
                int currentValue = romanToIntMap[s[i]];
                
                if (currentValue >= lastNum)
                {
                    total += currentValue;
                }else
                {
                    total -= currentValue;
                }

                //Update lastNum
                lastNum = currentValue;
            }
            return total;
        }
    }
}
