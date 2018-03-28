using System;

namespace LinkedList
{
    class DeleteGiven
    {
        //public static void Main(string[] srgs)
        //{
        //    MyVersion();
        //    //CTCIVersion();
        //}

        public static void MyVersion()
        {
            LinkedListNode node = new LinkedListNode { Data = 10 };
            node.Next = new LinkedListNode { Data = 20 };
            node.Next.Next = new LinkedListNode { Data = 30 };
            node.Next.Next.Next = new LinkedListNode { Data = 40 };
            node.Next.Next.Next.Next = new LinkedListNode { Data = 50 };

            Console.WriteLine("*****************************Before*****************************");
            var temp = node;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            var nodeToDelete = node.Next.Next;

            while (nodeToDelete.Next != null)
            {
                nodeToDelete.Data = nodeToDelete.Next.Data;
                nodeToDelete.Next = nodeToDelete.Next.Next;
                nodeToDelete = nodeToDelete.Next;
            }

            Console.WriteLine("*****************************After*****************************");
            temp = node;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            Console.ReadLine();
        }


        public static void CTCIVersion()
        {
            LinkedListNode node = new LinkedListNode { Data = 10, Next = null, Previous = null };
            node.Next = new LinkedListNode { Data = 20, Next = null, Previous = null };
            node.Next.Next = new LinkedListNode { Data = 30, Next = null, Previous = null };
            node.Next.Next.Next = new LinkedListNode { Data = 40 };
            node.Next.Next.Next.Next = new LinkedListNode { Data = 50 };

            Console.WriteLine("*****************************Before*****************************");
            var temp = node;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            var nodeToDelete = node.Next.Next;

            if (nodeToDelete == null || nodeToDelete.Next == null)
            {
                Console.WriteLine("Unable to delete the node");
            }

            nodeToDelete.Data = nodeToDelete.Next.Data;
            nodeToDelete.Next = nodeToDelete.Next.Next;

            Console.WriteLine("*****************************Before*****************************");
            temp = node;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            Console.ReadLine();
        }

    }
}
