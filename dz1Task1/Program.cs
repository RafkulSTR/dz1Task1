namespace dz1Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task2();
            task4();
            task6();
            task8();
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

        //
        //на вход принимает число и выдаёт, является ли число чётным
        //
        static private void task6()
        {
            Console.Write("Введите  число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number % 2) == 0)
            {
                Console.WriteLine("Число является четным");
            }
            else 
            {
                Console.WriteLine("Число является нечетным");
            }
        }

        static private void task8()
        {
            Console.Write("Введите  число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) 
            {
                int count = 0;
                while (count < number) 
                { 
                    count++;
                    if ((count % 2) == 0) 
                    {
                        Console.WriteLine(count);
                    }

                }
            }

        }
    }
}