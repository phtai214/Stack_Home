using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Home
{
    class StackDoan
    {
        private Stack<Tuple<int, int>> stackDoan;

        public StackDoan()
        {
            stackDoan= new Stack<Tuple<int, int>>();
        }

        public void Push(int left, int right)
        {
            stackDoan.Push(new Tuple<int, int>(left, right));
        }
        public bool Pop(out int left, out int right)
        {   
            left = right = 0;
            if(stackDoan.Count == 0)
                return false;

            Tuple<int, int> doan= stackDoan.Pop();
            left= doan.Item1;
            right= doan.Item2;
            return true;
        }
    }
}
