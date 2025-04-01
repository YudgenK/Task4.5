using System;

namespace ConsoleApp1.Task
{
    class task3
    {
        public void Run()
        {
            Console.WriteLine(Book.Content);

            Console.Write("Введіть текст для пошуку: ");
            string searchText = Console.ReadLine();
            FindAndReplaceManager.FindNext(searchText);

            Console.Write("Бажаєте додати нотатку? (так/ні): ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "так")
            {
                Console.Write("Введіть вашу нотатку: ");
                string note = Console.ReadLine();
                Book.Notes.AddNote(note);
            }

            Console.WriteLine("\n Усі нотатки:");
            Book.Notes.ShowNotes();
        }

        class Book
        {
            public static string Content = "Це книга. Вона містить текст. Шукайте потрібне слово тут.";

            public static class Notes
            {
                private static string _notes = "";

                public static void AddNote(string note)
                {
                    if (!string.IsNullOrEmpty(_notes))
                        _notes += "\n";
                    _notes += note;
                    Console.WriteLine("Нотатку збережено.");
                }

                public static void ShowNotes()
                {
                    if (string.IsNullOrEmpty(_notes))
                        Console.WriteLine("Нотаток поки що немає.");
                    else
                        Console.WriteLine(_notes);
                }
            }
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
