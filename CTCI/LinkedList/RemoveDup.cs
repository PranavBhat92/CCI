using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class RemoveDup
    {
        public static void Main(string[] srgs)
        {
            CTCIVersion1();
            //CTCIVersion2();
        }

        static LinkedListNode node = new LinkedListNode
        {
            Data = 1,
            Next = null,
            Previous = null
        };

        public static void CTCIVersion1()
        {
            HashSet<int> set = new HashSet<int>();
            
            LinkedListNode prev = null;

            while (node != null)
            {
                if (set.Contains(node.Data))
                {
                    prev.Next = node.Next;
                }
                else
                {
                    prev = node;
                    set.Add(node.Data);
                }

                node = node.Next;
            }
        }

        public static void CTCIVersion2()
        {
            LinkedListNode current = node;

            while (current != null)
            {
                LinkedListNode runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data != current.Data)
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }
        }

    }
}
