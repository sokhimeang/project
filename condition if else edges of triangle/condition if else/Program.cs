using System;

namespace condition_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            float sidea,sideb,sidec,p;
            Console.Write("side a= ");
            sidea = float.Parse(Console.ReadLine());
            Console.Write("side b= ");
            sideb = float.Parse(Console.ReadLine());
            Console.Write("side c= ");
            sidec = float.Parse(Console.ReadLine());
            if (sidea + sideb <= sidec || sidea + sidec <= sideb || sideb + sidec <= sidea || sidea <= 0 || sideb <= 0 || sidec <= 0)
            {
                Console.Write("these are not the edges of triangle");
            }
            else
            {
                p = (sidea + sideb + sidec) / 2;
                Console.Write("S = {0}", Math.Sqrt(p * (p - sidea) * (p - sideb) * (p - sidec)));
            }

            Console.ReadLine();
        }
    }
}
