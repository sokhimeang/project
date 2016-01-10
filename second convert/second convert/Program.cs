using System;

namespace second_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds, minuites=0, hours=0;
            Console.Write("type seconds: ");
            seconds = int.Parse(Console.ReadLine());
            if(seconds>=0)
            {
                hours = seconds / 3600;
                minuites = seconds / 60 - hours * 60;
                seconds = seconds - minuites * 60 - hours * 3600;
                Console.Write("convert: {0}: {1}: {2}", hours, minuites, seconds);
            }
            else
            {
                Console.Write("error: seconds >=0");
            }            

            Console.ReadLine();
        }
    }
}
