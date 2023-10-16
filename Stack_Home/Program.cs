using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Home
{
    class Program
    {
        static void Input(ArrayStack arrStack)
        {
            while (true)
            {
                Console.Write("Nhap gia tri stack (am de dung):" + " ");
                int input;
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input < 0)
                        break;
                    else
                    {
                        if (!arrStack.Push(input))
                        {
                            Console.WriteLine("Stack da day, khong the them gia tri nao!!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le vui long nhap lai so nguyen!");
                }
            }
        }
        static void Output(ArrayStack arrStack)
        {
            while (!arrStack.IsEmpty)
            {
                int topItem;
                if (arrStack.GetTop(out topItem))
                {
                    Console.WriteLine($"Dinh Stack: {topItem}");
                }
                int outItem;
                if (arrStack.Pop(out outItem))
                {
                    Console.WriteLine($"Lay ra: {outItem}");
                }
            }
        }
        static void Input(ListStack listStack)
        {
            while (true)
            {
                Console.Write("Nhap gia tri stack(am de dung):" + " ");
                int input;
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input < 0)
                        break;

                    else
                        listStack.Push(input);
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le vui long nhap lai so nguyen!");
                }
            }
        }
        static void Output(ListStack listStack)
        {
            while (!listStack.IsEmpty)
            {
                int topItem;
                if (listStack.GetTop(out topItem))
                {
                    Console.WriteLine($"Dinh Stack: {topItem}");
                }
                int outItem;
                if (listStack.Pop(out outItem))
                {
                    Console.WriteLine($"Lay ra: {outItem}");
                }
            }
        }
        static void TestArrayStack()
        {
            ArrayStack arrStack = new ArrayStack(1000);
            Input(arrStack);
            Console.WriteLine("Cac gia tri trong stack:" + " ");
            Console.WriteLine();
            Output(arrStack);
        }
        static void TestListStack()
        {
            ListStack listStack = new ListStack();
            Input(listStack);
            Console.WriteLine("Cac gia tri trong stack:" + " ");
            Console.WriteLine();
            Output(listStack);
        }

        static void PrintArray(int[] arr)
        {
            foreach(int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //TestArrayStack();
            //TestListStack();

            Console.Write("Nhap cac gia tri vao mang: ");
            string input = Console.ReadLine();

            string[] inputNumbers = input.Split(' ');
            int[] array = new int[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (int.TryParse(inputNumbers[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le: " + inputNumbers[i]);
                    return;
                }
            }

            IntArray intArray = new IntArray(array);
            Console.WriteLine("Mang ban dau: ");
            PrintArray(array);
            intArray.QuickSort();
            Console.WriteLine("Mang sau khi sap xep: ");
            PrintArray(array);
        }
    }
}
