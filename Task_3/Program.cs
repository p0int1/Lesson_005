using System;
//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с 
//возможностью изменения числа строк и столбцов.
//Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(5, 5);
            matrix.Show();

            Console.WriteLine("------------------------------");
            Console.WriteLine("[1][2] = {0}", matrix[1, 2]);
            Console.WriteLine("[4][2] = {0}", matrix[4, 2]);
            matrix[0, 0] = 11;

            Console.WriteLine("------------------------------");
            matrix.ChangeSize(7, 6);
            matrix.Show();

            Console.WriteLine("------------------------------");
            matrix.ShowPartly(1, 0, 4, 4);

            //Delay
            Console.ReadKey();

        }
    }
}
