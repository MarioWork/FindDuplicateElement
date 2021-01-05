using System;
using System.Collections.Generic;


namespace FindDuplicateElement
{

    //Find duplicate element in a limited range array
    //Given a limited range array of size n where array
    //contains elements between 1 to n-1 with one element repeating,
    //find the duplicate number in it.
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,9,5,6,7,8,9};

            Console.WriteLine($"The duplicate element is: {FindDuplicateElement(array)}");

        }

        public static int FindDuplicateElement(int[] array)
        {

            Dictionary<int, int> valuesChecked = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (valuesChecked.ContainsValue(array[i]))
                {
                    return array[i];
                }

                valuesChecked.Add(i, array[i]);
            }

            return 0;
        }
    }
}
