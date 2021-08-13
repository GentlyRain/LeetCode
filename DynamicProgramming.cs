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
        /// 一维动态规划
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

            // 赋初值（最优子结构）
            dp[1] = 1;
            dp[2] = 2;

            // 通过关系式来计算出 dp[n]
            for (int i = 3; i < dp.Length; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }



        /// <summary>
        /// 二维动态规划
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int UniquePath(int m, int n)
        {
            if (m <= 0 || n <= 0)
            {
                return 0;
            }

            // 保存历史数据
            int[,] dp = new int[m + 1, n + 1];

            // 初始化（最优子结构）
            for (int i = 0; i < m + 1; i++)
            {
                dp[i, 0] = 1;
            }
            for (int i = 0; i < n + 1; i++)
            {
                dp[0, i] = 1;
            }

            // 通过关系式来计算出 dp[m, n]
            for (int i = 1; i < m + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m, n];
        }
    }
}
