using System;

namespace ConsoleApp1.Task
{
    class task4
    {
         public void Run()
        {
            int[] numbers = { 5, 2, 8, 1, 3 };

            Console.WriteLine("Масив до сортування:");
            Console.WriteLine(string.Join(", ", numbers));

            numbers.SortAscending();

            Console.WriteLine("Масив після сортування:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
    static class ArrayExtensions
    {
        public static void SortAscending(this int[] array)
        {
            Array.Sort(array);
        }
    }

    
}
