using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*** 链表倒置 ***/
                NodeList node5 = new NodeList(5, null);
                NodeList node4 = new NodeList(4, node5);
                NodeList node3 = new NodeList(3, node4);
                NodeList node2 = new NodeList(2, node3);
                NodeList node1 = new NodeList(1, node2);

                // 递归
                NodeList newNodeList = NodeList.Recursion(node1);
                Console.WriteLine($"{newNodeList}");
                /*** 链表倒置 ***/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            Console.ReadLine();
        }
    }
}
