using System;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, number3;
            number1 = float.Parse(Console.ReadLine());
            number2 = float.Parse(Console.ReadLine());
            number3 = float.Parse(Console.ReadLine());
            Console.Write("average of them is: {0}; {1}& {2} la: {3}", number1, number2, number3, (number1 + number2 + number3) / 3);
            Console.ReadLine();
        }
    }
}
