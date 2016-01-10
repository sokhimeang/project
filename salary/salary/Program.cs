using System;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary;
            int month;
            Console.Write("How many months?: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("total salary is: {0} Million dong(VND)", month * 3.16);
            Console.ReadLine();
        }
    }
}
