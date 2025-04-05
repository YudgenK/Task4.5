using System;

namespace ConsoleApp1.Task
{
    class task4
    {
         public void Run()
        {
            Article[] articles = new Article[]
            {
                new Article("Телевізор", "Магазин 1", 8999.99),
                new Article("Смартфон", "Магазин 2", 4999.99),
                new Article("Ноутбук", "Магазин 3", 15999.99)
            };

            Store store = new Store(articles);

            Console.WriteLine("Введіть індекс товару для перегляду (0-2): ");
            int index = int.Parse(Console.ReadLine());
            store.ShowProductByIndex(index);

            Console.WriteLine("Введіть назву товару для пошуку: ");
            string productName = Console.ReadLine();
            store.ShowProductByName(productName);
        }
    }
    class Article
    {
        public string ProductName { get; private set; }
        public string StoreName { get; private set; }
        public double Price { get; private set; }
        public Article(string productName, string storeName, double price)
        {
            ProductName = productName;
            StoreName = storeName;
            Price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Товар: {ProductName}, Магазин: {StoreName}, Вартість: {Price} грн.");
        }
    }

    class Store
    {
        private Article[] articles;
        public Store(Article[] articles)
        {
            this.articles = articles;
        }
        public void ShowProductByIndex(int index)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index].DisplayInfo();
            }
            else
            {
                Console.WriteLine("Товар з таким індексом не знайдено!");
            }
        }

        public void ShowProductByName(string productName)
        {
            bool found = false;
            foreach (var article in articles)
            {
                if (article.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    article.DisplayInfo();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Товар з таким назвою не знайдено!");
            }
        }
    }


}
