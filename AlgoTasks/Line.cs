using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTasks
{
    class Line
    {
        public int a, b, s;
        public Line()
        {
            Console.WriteLine("Введите координату начала: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату конца: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество отрезков: ");
            s = int.Parse(Console.ReadLine());
        }
        public void t()
        {
            int len = b - a;
            double incr = len / s;
            Console.WriteLine("start\t| end\t| sin\t| cos");
            for (double i=a;i<b; i += incr)
            {
                Console.Write(Math.Round(i,2) + "\t| " + Math.Round((i+incr),2) + "\t| " + 
                    Math.Round(Math.Sin(i),2) +"\t| "+ Math.Round(Math.Cos(i), 2));
                Console.WriteLine();
            }

        }
    }
}
