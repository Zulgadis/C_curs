using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_app_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Please enter KM");
            int kmMeters;
            kmMeters = int.Parse(Console.ReadLine());


            Console.WriteLine(kmMeters + "km to meters = " + kmMeters * 1000 + "m");

            Console.WriteLine("Please enter OST");
            int ost;
            ost = int.Parse(Console.ReadLine());
            Console.WriteLine(ost + " % 2 = " + ost % 2);


            Console.WriteLine("Please enter number");
            int number;
            number = int.Parse(Console.ReadLine());

           
            Console.WriteLine(number + " " + number / 1000 + " " + number / 100%10 + " " + number / 10%10 + " " + number % 10);

    */
            Console.WriteLine("Enter km Number");
            int km;
            km = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter l/1km");
            int lit;
            lit = int.Parse(Console.ReadLine());

            Console.WriteLine(lit * km + " lir we spend per " + km + " km");


          

        }
    }
}
