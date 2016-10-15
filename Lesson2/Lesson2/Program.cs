using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter Number1");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int a2 = int.Parse(Console.ReadLine());
            if (a1 > a2)
            {
                Console.WriteLine("{0} Number beger than {1}", a1, a2);
            }
            else if (a1 == a2)
            {
                Console.WriteLine("{0} iqule {1}", a1, a2);
            }
            else
            {
                Console.WriteLine("{0} Number smaller than {1}", a1, a2);
            }
                 
            
            Console.WriteLine("Enter Number1");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int a2 = int.Parse(Console.ReadLine());
            if (a1 % 2 == 0)
                Console.WriteLine($"{a1}");
            else
                Console.WriteLine("None1");

            if (a2 % 2 == 0)
                Console.WriteLine($"{a2}");

            else
                Console.WriteLine("None2");
               

            Console.WriteLine("Enter NUmber");
            int a1 = int.Parse(Console.ReadLine());
            int F = a1 % 5 == 0 ? 5 : a1;
            Console.WriteLine(F);
            

            const float pi = 3.14f;
            Console.WriteLine("Enter rad");
            int rad = int.Parse(Console.ReadLine());
            string F = 2 * rad * pi > 50 ? "Rad to big" : "Rad is good";
            Console.WriteLine(F);
               

            Console.WriteLine("Enter Number");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Workdays");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;

                default:
                    Console.WriteLine("??????????");
                    break;
            }
            */

            int total = 0;
            Console.WriteLine("Qustion 1\nNumber of days in the year?\na)\t362\nb)\t912\nc)\t365");
            string q1 = Console.ReadLine();
            switch (q1)
            {
                case "a":
                    Console.WriteLine("Correct");
                    total++;
                    break;
                case "b":
                case "c":
                    Console.WriteLine("Wrong");
                    break;
                default:
                    Console.WriteLine("??????????????????????");
                    break;
            }
            Console.WriteLine("Qustion 2\nNumber of days in week?\na)\t4\nb)\t7\nc)\t12");
            string q2 = Console.ReadLine();
            switch (q2)
            {
                case "a":
                case "c":
                    Console.WriteLine("Wrong");
                    break;
                case "b":
                    Console.WriteLine("Correct");
                    total++;
                    break;
                default:
                    Console.WriteLine("??????????????????????");
                    break;
            }
            Console.WriteLine("Qustion 3\nNumber monsth in year?\na)\t9\nb)\t267\nc)\t12");
            string q3 = Console.ReadLine();
            switch (q3)
            {
                case "a":
                case "b":
                    Console.WriteLine("Wrong");
                    break;
                case "c":
                    Console.WriteLine("Correct");
                    total++;
                    break;
                default:
                    Console.WriteLine("??????????????????????");
                    break;
            }
            if (total <= 1)
                Console.WriteLine("Bad");
            else if (total == 2)
                Console.WriteLine("Normal");
            else
                Console.WriteLine("Very good");
           


        }

    }
}
