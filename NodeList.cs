using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 链表
    /// </summary>
    public class NodeList
    {
        int val;
        NodeList next;

        public NodeList(int val, NodeList next)
        {
            this.val = val;
            this.next = next;
        }



        /// <summary>
        /// 迭代
        /// </summary>
        /// <returns></returns>
        public static NodeList Recursion(NodeList head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            NodeList newNodeList = Recursion(head.next);
            head.next.next = head;
            head.next = null;

            return newNodeList;
        }
    }
}
