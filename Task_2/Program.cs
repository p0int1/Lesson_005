using System;
//Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создать массив размерностью N элементов, заполнить его произвольными целыми значениями. 
//Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
//среднее арифметическое всех элементов, вывести все нечетные значения.

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array instance = new Array(13);

            instance.MinValue();
            instance.MaxValue();
            instance.SumItems();
            instance.Average();
            instance.OddValues();

            Console.ReadKey();

        }
    }
}
