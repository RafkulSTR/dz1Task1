﻿namespace dz1Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task2();
            task4();
        }

        //
        //Метод принимает два числа и выводит максимальное число
        //
        static private void task2()
        {
            Console.Write("Введите первое число: ");
            int numberFirst = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int NumberSecond = Convert.ToInt32(Console.ReadLine());

            if (numberFirst > NumberSecond)
                Console.WriteLine($"Максимальное число =  {numberFirst}");
            else Console.WriteLine($"Максимальное число =  {NumberSecond}");
        }

        //
        //Метод принимает три числа и выдает максимальное из этих чисел
        //
        static private void task4()
        {
            Console.Write("Введите первое число: ");
            int numberFirst = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int NumberSecond = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int NumberThird = Convert.ToInt32(Console.ReadLine());

            int max = numberFirst;

            if (max < NumberSecond)
            {
                max = NumberSecond;
            }
            if (max < NumberThird)
            {
                max = NumberThird;
            }
            Console.WriteLine(max);
        }
    }
}