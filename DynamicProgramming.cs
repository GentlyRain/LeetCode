using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*** 动态规划问题 ***/
    class DynamicProgramming
    {
        /// <summary>
        /// 一维线性规划问题
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GoUpstairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            // 保存历史数据
            int[] dp = new int[n + 1];

            // 赋初值
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i < dp.Length; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
