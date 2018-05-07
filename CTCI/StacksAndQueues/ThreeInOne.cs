using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class ThreeInOne
    {
        //public static void Main(string[] args)
        //{
        //    CTCIVersion();
        //}

        public static void CTCIVersion()
        {
            var stacks = new FixedMultiStack(3);

            stacks.push(0, 1);
            stacks.push(0, 2);
            stacks.push(0, 3);
            stacks.push(1, 4);
            stacks.push(1, 5);
            stacks.push(1, 6);
            stacks.push(2, 7);
            stacks.push(2, 8);
            stacks.push(2, 9);
            
            // All stack operations can be performed from here
        }

    }

    public class FixedMultiStack
    {
        private int noOfStacks = 3;
        private int stackCapacity;
        private int[] values;
        private int[] sizes;

        public FixedMultiStack(int capacity)
        {
            stackCapacity = capacity;
            values = new int[capacity*noOfStacks];
            sizes = new int[noOfStacks];
        }



        public void push(int stackNum,int value) {
            if (IsFull(stackNum))
            {
                Console.WriteLine("Stack Full!");
                return;
            }

            values[IndexOfTop(stackNum)] = value;
            sizes[stackNum]++;
        }


        public int Pop(int stackNum)
        {
            if (IsEmpty(stackNum))
            {
                Console.WriteLine("Stack Empty!");
                return -1;
            }

            var index = values[IndexOfTop(stackNum)];
            var val = values[index];
            sizes[stackNum]--;
            return val;
        }


        public int Peek(int stackNum)
        {
            if (IsEmpty(stackNum))
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }

            return values[IndexOfTop(stackNum)];
        }


        public bool IsEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }

        public bool IsFull(int stackNum)
        {
            return sizes[stackNum] == stackCapacity;
        }

        public int IndexOfTop(int stackNum)
        {
            var offset = stackNum * stackCapacity;
            var size = sizes[stackNum];
            return offset + size;
        }


    }

}
