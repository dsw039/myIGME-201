using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Daniel Wright
//Program: Emulation of the stack template with Push,Pop, and Peek
namespace Final_exam_1
{
    public class MyStack
    {
        private List<int> stackList;

        public MyStack()
        {
            stackList = new List<int>();
        }

        //Push method
        public void Push(int n)
        {
            //Adds something to the end of the list like push would normally do
            stackList.Add(n);
        }

        public int Pop()
        {
            //Grabs index of the last item of list
            if (stackList.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            int lastIndex = stackList.Count - 1;
            int poppedItem = stackList[lastIndex];
            stackList.RemoveAt(lastIndex);
            return poppedItem;
        }

        public int Peek()
        {
            if (stackList.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return stackList[stackList.Count - 1];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
