using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCode1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //
            for (int i = 0; i < nums.Count; i++)
            {
                for (int z = i+1; z < nums.length - 1; z++)
                {
                    if (nums[i] + nums[z] == target)
                    {
                        return [i, z];
                    }
                }
            }

        }
    }


}
