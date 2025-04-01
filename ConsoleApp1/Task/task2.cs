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
            Console.Write("Введіть текст для пошуку: ");
            string searchText = Console.ReadLine();

            FindAndReplaceManager.FindNext(searchText);
        }
        class Book
        {
            public static string Content = "Це книга. Вона містить текст. Шукайте потрібне слово тут.";
        }

        static class FindAndReplaceManager
        {
            public static void FindNext(string str)
            {
                if (Book.Content.Contains(str))
                    Console.WriteLine($"Знайдено: \"{str}\" є в книзі.");
                else
                    Console.WriteLine($"Не знайдено: \"{str}\" в книзі немає.");
            }
        }


    }
}
