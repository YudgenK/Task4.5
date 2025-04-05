using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task2
    {
        public void Run()
        {
            Console.Write("Введіть розмір масиву: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            Console.WriteLine("Масив: ");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                sum += num;
            }

            double average = (double)sum / n;
            Console.WriteLine($"\nНайбільше значення: {max}");
            Console.WriteLine($"Найменше значення: {min}");
            Console.WriteLine($"Загальна сума елементів: {sum}");
            Console.WriteLine($"Середнє арифметичне: {average:F2}");

            Console.WriteLine("\nНепарні числа в масиві:");
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    
    }
}
