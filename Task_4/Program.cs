using System;
//Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создать класс Article, содержащий следующие закрытые поля:
//• название товара;
//• название магазина, в котором продается товар;
//• стоимость товара в гривнах.
//Создать класс Store, содержащий закрытый массив элементов типа Article. 
//Обеспечить следующие возможности:
//• вывод информации о товаре по номеру с помощью индекса;
//• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет,
//выдать соответствующее сообщение;
//Написать программу, вывода на экран информацию о товаре.

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store article = new Store(4);

            article.NewArticle(new Article("Cheese", "Varus", 159.90), 0);
            article.NewArticle(new Article("Big Mac", "mcdonalds", 123), 1);
            article.NewArticle(new Article("Apple Watch", "Comfy", 999), 2);
            article.NewArticle(new Article("ACER", "Foxtrot", 13499), 3);

            Console.WriteLine(article["ACER"]);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine(article[2]);
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();

        }
    }
}
