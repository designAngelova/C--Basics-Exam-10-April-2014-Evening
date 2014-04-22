using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Eclipse
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char star = '*';
            char dash = '-';
            char slash = '/';
            char space = ' ';
            //first line
            for (int i = 0; i < 1; i++)
            {
                Console.Write(space);
                Console.Write(new string (star, 2*n-2));
                Console.Write(new string(space, n + 1));
                Console.Write(new string(star, 2 * n - 2));
                Console.WriteLine(space);
            }
            //between first and last lines
            for (int i = 2; i < n; i++)
            {
               Console.Write(star);
               Console.Write(new string(slash, 2*n-2));
               Console.Write(star);

               if (i == n / 2 + 1)
               {
                   Console.Write(new string(dash, n - 1));
               }
               else
               {
                   Console.Write(new string(space, n - 1));
               }
               Console.Write(star);
               Console.Write(new string(slash, 2 * n - 2));
               Console.WriteLine(star);
               
            }
            //last line the same as first line
            for (int i = 0; i < 1; i++)
            {
                Console.Write(space);
                Console.Write(new string(star, 2 * n - 2));
                Console.Write(new string(space, n + 1));
                Console.Write(new string(star, 2 * n - 2));
                Console.WriteLine(space);
            }
        }
    }
