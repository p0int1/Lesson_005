using System;

namespace Task_2
{
    class Array
    {
        int[] array;

        public Array(int size)
        {
            array = new int[size];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write(array[i] + ", ");
            }
            // удаление последней запятой и перевод на новую строку
            Console.Write((char)8 + (char)8 + "\n"); 
        }

        public void MinValue()
        {
            int min = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            Console.WriteLine("Min = " + min);
        }

        public void MaxValue()
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine("Max = " + max);
        }

        public int SumItems(bool NoPrint = false)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            if(!NoPrint)
                Console.WriteLine("Sum = " + sum);
            return sum;
        }

        public void Average()
        { 
            int average = SumItems(true) / array.Length;
            Console.WriteLine("Average = " + average);
        }

        public void OddValues()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine("Odd value: " + array[i]);
                }
            }
        }
    }
}
