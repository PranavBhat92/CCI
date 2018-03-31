using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Partition
    {
        //public static void Main(string[] srgs)
        //{
        //    //MyVersion();    // Not Working
        //    // The catch here is that I sould ask the interviewer whether I can use extra linked list
        //    CTCIVersion();
        //}
        
        public static void MyVersion()
        {
            LinkedListNode node = new LinkedListNode { Data = 3 };
            node.Next = new LinkedListNode { Data = 5 };
            node.Next.Next = new LinkedListNode { Data = 8 };
            node.Next.Next.Next = new LinkedListNode { Data = 5 };
            node.Next.Next.Next.Next = new LinkedListNode { Data = 10 };
            node.Next.Next.Next.Next.Next = new LinkedListNode { Data = 2 };
            node.Next.Next.Next.Next.Next.Next = new LinkedListNode { Data = 1 };

            Console.WriteLine("*****************************Before*****************************");
            var temp = node;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            var theNode = node;
            LinkedListNode aNode = null;
            var key = 5;

            while (theNode != null)
            {
                if (theNode.Next.Data == key)
                {
                    aNode = theNode;
                    break;
                }
                theNode = theNode.Next;
            }

            LinkedListNode back = aNode;
            theNode = theNode.Next;

            while (theNode.Next != null)
            {
                if (theNode.Next.Data < key)
                {
                    back.Next = theNode.Next;
                    theNode.Next = theNode.Next.Next;
                    back = back.Next;
                }
                    theNode = theNode.Next;
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
            LinkedListNode node = new LinkedListNode { Data = 3 };
            node.Next = new LinkedListNode { Data = 5 };
            node.Next.Next = new LinkedListNode { Data = 8 };
            node.Next.Next.Next = new LinkedListNode { Data = 5 };
            node.Next.Next.Next.Next = new LinkedListNode { Data = 10 };
            node.Next.Next.Next.Next.Next = new LinkedListNode { Data = 2 };
            node.Next.Next.Next.Next.Next.Next = new LinkedListNode { Data = 1 };

            Console.WriteLine("*****************************Before*****************************");
            var temp = node;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }


            var x = 5;
            LinkedListNode beforeStart = null;
            LinkedListNode beforeEnd = null;
            LinkedListNode afterStart = null;
            LinkedListNode afterEnd = null;
            var flag = true;



            while (node != null)
            {
                LinkedListNode next = node.Next;
                node.Next = null;
                if (node.Data < x)
                {
                    if (beforeStart == null)
                    {
                        beforeStart = node;
                        beforeEnd = beforeStart;
                    }
                    else
                    {
                        beforeEnd.Next = node;          // Attach the element to beforeEnd
                        beforeEnd = beforeEnd.Next;               // navigate
                    }
                }
                else
                {
                  
                  if (afterStart == null)
                    {
                        afterStart = node;
                        afterEnd = afterStart;
                    }
                    else
                    {
                        afterEnd.Next = node;
                        afterEnd = afterEnd.Next;
                    }
                }
                node = next;
            }

            if (beforeStart == null)
            {
                flag = false;
            }
            else
            {
                beforeEnd.Next = afterStart;
            }

            if (flag == false)
            {
                temp = afterStart;
            }
            else
            {
                temp = beforeStart;
            }

            Console.WriteLine("*****************************After*****************************");
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

            Console.ReadLine();


        }

    }
}
