using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    /*
     * Question 1 - Two Sum - Easy
     * */
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //Dictionary
            var numDict = new Dictionary<int, int>();

            //Result in a 2 array int.
            var result = new int[2];

            //For loop to go through array
            for (int i = 0; i < nums.Length; i++)
            {
                //The result of current number - target aka the compliment to current.
                var complimentNum = target - nums[i];

                //If does not exist
                if(!numDict.ContainsKey(complimentNum))
                {
                    //Store in map/dict by using actual number (nums[i]) as key and index (i) as value
                    numDict[nums[i]] = i;
                }
                else //Does exist
                {
                    //Store the number itself first, then its index in result
                    result[0] = numDict[complimentNum];
                    result[1] = i;
                    return result;
                }
            }
            return result;
        }
    }
}
