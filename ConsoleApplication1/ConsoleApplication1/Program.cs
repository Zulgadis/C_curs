using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Please Enter km = ");
                         int km = int.Parse(Console.ReadLine());
             int metr = km * 1000;
             Console.WriteLine(km + "km = " + metr + " m");
             Console.WriteLine("{0} km = {1} m", km, metr );
             Console.WriteLine($"{km} km = {metr} m");

    

            Console.Write("Please Enter km = ");
            float km = float.Parse(Console.ReadLine());
            Console.Write("Please Enter 1 lit/100km = ");
            float lit100km = float.Parse(Console.ReadLine());
            float lit1km = lit100km / 100;
            float total = km * lit1km;
            Console.WriteLine($"On {km}km car use {lit100km} per 100km. Total use = {total}");*/

            Console.Write("Please Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product1: ");
            string prod1 = Console.ReadLine();
            Console.Write($"Enter {prod1} cost: ");
            float costProd1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Product2: ");
            string prod2 = Console.ReadLine();
            Console.Write("Enter {0} cost: ", prod2);
            float costProd2 = float.Parse(Console.ReadLine());
            Random rand = new Random();
            int order = rand.Next(1111,9999);
            float total = costProd1 + costProd2;
            float tips = total * 0.1f;

            Console.Write("Order:\t{0}\nName:\t{1}\nPrice:\n{2}\t{3}\n{4}\t{5}\nTotal:\t{6}\nTips:\t{7:0.00}\n", order, name, prod1, costProd1, prod2, costProd2, total, tips);






        }
    }
}
