using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 1
            /*
            Console.WriteLine("Please enter distans: ");
            int dis = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter time of the day:\na)\tday\nb)\tnight");
            string time = Console.ReadLine();
            float money = dis;
            switch (time)
            {
                case "day":
                case "a":
                    if (dis <= 15)
                        money = money * 5;
                    else if (dis > 15 && dis <= 30)
                        money = money * 4;
                    else
                        money = money * 2;
                    break;
                case "night":
                case "b":
                    if (dis <= 15)
                        money = (money * 5) / 2;
                    else if (dis > 15 && dis <= 30)
                        money = (money * 4) / 2;
                    else
                        money = (money * 2) / 2;
                    break;
            }
            money = money + 30;
            Console.WriteLine($"The {dis} km in {time} will be coast {money:0.00} ");
            */

            //Вариант 2
            Console.WriteLine("Please enter distans: ");
              int dis = int.Parse(Console.ReadLine());
              Console.WriteLine("Please enter time of the day:\na)\tday\nb)\tnight");
              string time = Console.ReadLine();
              float money = dis;
              if (dis <= 15)
                  money = money * 5;
              else if (dis > 15 && dis <= 30)
                  money = money * 4;
              else
                  money = money * 2;
              if (time == "night")
                  money = money / 2;    
              money = money + 30;
              Console.WriteLine($"The {dis} km in {time} will be coast {money} ");
              
        }
    }
}
