using System;

namespace ConsoleApp1.Task
{
    class task6
    {
        public void Run()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);    
            Console.WriteLine(dictionary["стіл"]);     
            Console.WriteLine(dictionary["sun"]);      
            Console.WriteLine(dictionary[0]);         
            Console.WriteLine(dictionary["молоко"]);  

        }
    }

    class Dictionary
    {
        private string[] keyRU = new string[5];  
        private string[] valueRU = new string[5]; 
        private string[] keyUA = new string[5];   
        private string[] valueUA = new string[5]; 
        private string[] keyEN = new string[5];

        public Dictionary()
        {
            
            keyRU[0] = "книга"; valueRU[0] = "book";
            keyRU[1] = "ручка"; valueRU[1] = "pen";
            keyRU[2] = "солнце"; valueRU[2] = "sun";
            keyRU[3] = "яблоко"; valueRU[3] = "apple";
            keyRU[4] = "стол"; valueRU[4] = "table";

            keyUA[0] = "книга"; valueUA[0] = "book";
            keyUA[1] = "ручка"; valueUA[1] = "pen";
            keyUA[2] = "сонце"; valueUA[2] = "sun";
            keyUA[3] = "яблуко"; valueUA[3] = "apple";
            keyUA[4] = "стіл"; valueUA[4] = "table";

            keyEN[0] = "book";
            keyEN[1] = "pen";
            keyEN[2] = "sun";
            keyEN[3] = "apple";
            keyEN[4] = "table";
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < keyRU.Length; i++)
                {
                    if (keyRU[i] == index)
                        return $"{keyRU[i]} (RU) - {valueRU[i]} (EN) / {keyUA[i]} (UA)";
                }

                for (int i = 0; i < keyUA.Length; i++)
                {
                    if (keyUA[i] == index)
                        return $"{keyUA[i]} (UA) - {valueUA[i]} (EN) / {keyRU[i]} (RU)";
                }

                for (int i = 0; i < keyEN.Length; i++)
                {
                    if (keyEN[i] == index)
                        return $"{keyEN[i]} (EN) - {keyRU[i]} (RU) / {keyUA[i]} (UA)";
                }

                return $"{index} - немає перекладу для цього слова.";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < keyRU.Length)
                    return $"{keyRU[index]} (RU) - {valueRU[index]} (EN) / {keyUA[index]} (UA)";

                return "Спроба звернення за межі масиву.";
            }
        }
    }
}