using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*** 动态规划 ***/
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
            for (int i = 3; i <= n; i++)
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



        /// <summary>
        /// 最短编辑距离
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static int MinEditDistance(string str1, string str2)
        {
            int[,] dp = new int[str1.Length + 1, str2.Length + 1];

            // 保存历史数据
            for (int i = 0; i <= str1.Length; i++)
            {
                dp[i, 0] = i;
            }
            for (int j = 0; j <= str2.Length; j++)
            {
                dp[0, j] = j;
            }

            // 对比最短编辑路径
            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    int flag = (str1[i - 1] == str2[j - 1]) ? 0 : 1;
                    dp[i, j] = MinDistance(
                        dp[i, j - 1] + 1,           // 添加
                        dp[i - 1, j] + 1,           // 删除
                        dp[i - 1, j - 1] + flag     // 替换
                        );
                }
            }

            return dp[str1.Length, str2.Length];
        }

        public static int MinDistance(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
