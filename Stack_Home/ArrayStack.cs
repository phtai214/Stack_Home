using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Stack_Home
{
    class ArrayStack
    {
        private int[] stkArray;
        private int stkMax;
        private int stkTop;

        public int[] StkArray { get => stkArray; set => stkArray = value; }
        public int StkMax { get => stkMax; set => stkMax = value; }
        public int StkTop { get => stkTop; set => stkTop = value; }

        public ArrayStack(int max = 0)
        {
            stkMax = max;
            stkArray = new int[max];
            stkTop = -1;
        }

        public bool IsEmpty => stkTop == -1;
        public bool IsFull => stkTop == stkMax - 1; 

        public bool Push(int x)
        {
            if (IsFull)
            {
                return false;
            }
            stkArray[++stkTop]=x;
            return true;
        }
        public bool Pop(out int outItem)
        {
            outItem = 0;
            if(IsEmpty)
            {
                return false;
            }
            outItem = stkArray[stkTop--];
            return true;
        }

        public bool GetTop(out int topItem)
        {
            topItem = 0;
            if (IsEmpty)
            {
                return false;
            }
            topItem = stkArray[stkTop];
            return true;
        }
    }
}
