using System;

namespace dientich
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, p, h;
            Console.Write("a= ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = float.Parse(Console.ReadLine());
            p = (a + b + c) / 2;
            Console.Write("h= ");
            h=float.Parse(Console.ReadLine());
            Console.Write("dien tich cua tam giac la: {0}", a * h / 2);
            Console.ReadLine();

        }
    }
}
