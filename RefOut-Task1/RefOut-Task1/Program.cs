using System;

namespace RefOut_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, 7 };

            InsertElement(ref nums, 3);

            foreach (int element in nums)
            {
                Console.WriteLine(element);
            }

        }

        static void InsertElement(ref int[] arr, int newElement)
        {
            int[] newArr = { 1, 5, 7, newElement };
            arr = newArr;
        }
    }
}
