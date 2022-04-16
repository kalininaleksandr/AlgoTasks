using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTasks
{
    class Triangle
    {
        public int ax, ay, bx, by, cx, cy;
        public double a, b, c, p, s,rv,sv,cv;
        string[] inp;
        public Triangle()
        {
            Console.WriteLine("Введите шесть координат вершин через пробел: ");
            inp = Console.ReadLine().Split(' ');
            if (this.isDataCorrect())
            {
                ax = int.Parse(inp[0]);
                ay = int.Parse(inp[1]);
                bx = int.Parse(inp[2]);
                by = int.Parse(inp[3]);
                cx = int.Parse(inp[4]);
                cy = int.Parse(inp[5]);
            }
        }
        public void showParams()
        {
            a = Math.Sqrt(((bx - cx) * (bx - cx)) + ((by - cy) * (by - cy)));
            b = Math.Sqrt(((cx - ax) * (cx - ax)) + ((cy - ay) * (cy - ay)));
            c = Math.Sqrt(((ax - bx) * (ax - bx)) + ((ay - by) * (ay - by)));
            p = a + b + c;
            s = Math.Sqrt((p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c)));
            rv = s / (p / 2);//радиус вписанной окружуности
            sv = Math.PI * rv * rv;//площадь вписанной окружности
            cv = 2 * Math.PI * rv;
            Console.WriteLine("Периметр: " + p + "\r\nПлощадь: " + s+"\r\nРадиус вписанной окружности: " +rv+
                "\r\nПлощадь вписанной окружности: "+sv+"\r\nДлина вписанной окружности: "+cv);
        }
        public bool isDataCorrect()
        {
            return inp.Length == 6;
        }
    }
}
