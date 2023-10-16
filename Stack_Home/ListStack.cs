using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Home
{
    class ListStack
    {
        Node top;
        internal Node Top { get => top; set => top = value; }
        public ListStack()
        {
            top = null;
        }
        public bool IsEmpty => top == null;

        public bool Push(int x)
        {
            Node newNode= new Node(x);
            newNode.Next = top;
            top = newNode;
            return true;
        }
        public bool Pop(out int outItem)
        {
            outItem = 0;
            if (IsEmpty)
            {
                return false;
            }
            outItem = top.Data;
            top= top.Next;
            return true;
        }
        public bool GetTop(out int topItem)
        {
            topItem = 0;
            if (IsEmpty)
            {
                return false;
            }
            topItem = top.Data;
            return true;
        }
    }
}
