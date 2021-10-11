using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата");
            int C = Convert.ToInt32(Console.ReadLine());
            int vert=0, hor=0;
            if (A>=C)
            {
                while (A >= C)
                {
                    A -= C;
                    vert++;
                }
            }
            else
            {
                Console.WriteLine("Квадрат не уместится в прямоугольнике");
            }
            if (B>=C)
            {
                while (B >= C)
                {
                    B -= C;
                    hor++;
                }
            }
            else
            {
                Console.WriteLine("Квадрат не уместится в прямоугольнике");
            }
            int N = 0; //колличество квадратов в прямоугольнике
            int i = 0;
            while (i<vert)
            {
                N += hor;
                i++;
            }
            Console.WriteLine("Количество квдаратов, размещенных в прямоугольнике N={0}",N);
            Console.ReadKey();


        }
    }
}
