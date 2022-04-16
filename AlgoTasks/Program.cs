using System;

namespace AlgoTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperMenu;
            Console.WriteLine("Выберите задачу:\r\n1 - окружность\r\n2 - Треугольник\r\n3 - отрезок\r\n4 - часы");
            upperMenu = Convert.ToInt32(Console.ReadLine());
            int menu = 0;
            string input;
            switch (upperMenu)
            {
                case 1:
                    Round rnd1 = new Round();
                    rnd1.showParams();
                    
                    break;
                case 2:
                    Triangle tr1 = new Triangle();
                    if (tr1.isDataCorrect())
                        tr1.showParams();
                    else
                        Console.WriteLine("Введено неверное число координат");
                    break;
                case 3:
                    Line l1 = new Line();
                    l1.t();

                    break;
                case 4:
                    OldWatch ow = new OldWatch();
                    break;  
            }
        }
    }
}
