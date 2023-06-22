namespace dz1Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            maxNumber();
        }

        static private void maxNumber()
        {
            Console.Write("Введите первое число: ");
            int numberFirst = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int NumberSecond = Convert.ToInt32(Console.ReadLine());

            if (numberFirst > NumberSecond)
                Console.WriteLine($"Максимальное число =  {numberFirst}") ;
            else Console.WriteLine($"Максимальное число =  {NumberSecond}");
        }
    }
}