using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Subject Name: ");
            string sub1 = Console.ReadLine();
            Console.Write($"Enter {sub1} Number of points: ");
            int point1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Name: ");
            string sub2 = Console.ReadLine();
            Console.Write($"Enter {sub2} Number of points: ");
            int point2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Name: ");
            string sub3 = Console.ReadLine();
            Console.Write($"Enter {sub3} Number of points: ");
            int point3 = int.Parse(Console.ReadLine());
            float summ = (point1 + point2 + point3) / 3f;
            Console.Write("{0}:\t{1}\n{2}\t{3}\n{4}\t{5}\nTotal:\t{6:0.00}\n", sub1, point1, sub2, point2, sub3, point3, summ);
            
            /*
            Console.Write("Please enter the circle radius: ");
            int rad = int.Parse(Console.ReadLine());
            float length = 3.14f * rad * 2;
            Console.Write("Radius:\t{0}\n Length:\t{1}\n", rad, length);
            */

        }
    }
}
