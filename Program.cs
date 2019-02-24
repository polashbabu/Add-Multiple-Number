using System;

namespace input_techniqe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number ");
            int number3 = int.Parse(Console.ReadLine());
            int add=number1 + number2 + number3;
            Console.WriteLine("The sum is\n" + add);
            Console.ReadKey();

        }
    }
}
