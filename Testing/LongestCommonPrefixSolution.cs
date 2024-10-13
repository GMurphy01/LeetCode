using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 14. Longest Commmon Prefix - Easy
*/
namespace Testing
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] srs)
        {
            //Get shortest string length
            int minLength = srs.Min(y => y.Length);

            //Set Binary ends
            var leftIndex = 0;
            var rightIndex = minLength - 1; //Last index of the shortest string

            //Until binary search is over
            while (leftIndex <= rightIndex)
            {
                //Get middle 
                int middle = (leftIndex + rightIndex) / 2; //int so decimal disappears

                //Check for common prefix
                if (IsCommonPrefix(srs,middle))
                {
                    //Move the leftIndex point one after middle and test again
                    leftIndex = middle + 1;
                }
                else
                {
                    //Move one before middle and test again
                    rightIndex = middle - 1;
                }
            }
            //Find middle of index's and add one for the answer
            return srs[0].Substring(0, rightIndex + 1);
        }

        //Check for common prefix
        private bool IsCommonPrefix(string[] strs, int length)
        {
            //First string, prefix from first to middle char
            string prefix = strs[0].Substring(0, length + 1);

            //start with second string
            for (int i = 1; i < strs.Length; i++)
            {
                //See if next string starts with same prefix or not
                if (!strs[i].StartsWith(prefix))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

