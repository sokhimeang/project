using System;

namespace basic_c_shard
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            Console.Write("{0}+{1}={2}",a,b,a+b);
            Console.ReadLine();
        }
    }
}
