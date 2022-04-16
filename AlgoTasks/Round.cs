using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTasks
{
    class Round
    {
        public double r, c, s;
        public Round()
        {
            Console.WriteLine("Введите радиус окружности: ");
            r = double.Parse(Console.ReadLine());
            c = 2 * Math.PI * r;
            s = Math.PI * r * r;
        }
        public void showParams()
        {
            Console.WriteLine("Длина окружности: " + Math.Round(c,2));
            Console.WriteLine("Площадь круга: " + Math.Round(s, 2));
        }
    }
}
