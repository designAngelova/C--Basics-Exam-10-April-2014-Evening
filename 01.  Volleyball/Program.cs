using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Volleyball
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int home = int.Parse(Console.ReadLine());
            const int weeks = 48;
            int normalWekkends= weeks-home;
            double result = normalWekkends *3.0/4.0+home*1.0+holidays*2.0/3.0;
            int holidaysPlay = 2 / 3 * holidays;
            int normalWeeksend = (weeks - home) * 3 / 4;
            if (leap == "leap")
            {
                result = result * 1.15;
            }
            
            Console.WriteLine((int)(result));
        }
    }

