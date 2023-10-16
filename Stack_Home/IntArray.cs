using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Home
{
    class IntArray
    {
        private int[] array;
        private int size;

        public IntArray(int[] arr)
        {
            array = arr;
            size = arr.Length;
        }

        private void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private int Partition(int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(i, j);
                }
            }

            Swap(i + 1, right);
            return i + 1;
        }

        public void QuickSort()
        {
            StackDoan stack = new StackDoan();
            stack.Push(0, size - 1);

            while (stack.Pop(out int left, out int right))
            {
                if (left >= right)
                    continue;

                int pivot = Partition(left, right);

                if (pivot - 1 > left)
                    stack.Push(left, pivot - 1);

                if (pivot + 1 < right)
                    stack.Push(pivot + 1, right);
            }
        }
    }
}
