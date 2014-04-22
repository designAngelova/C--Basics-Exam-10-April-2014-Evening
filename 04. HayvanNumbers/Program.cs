using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HayvanNumbers
    {
        static void Main ()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 555; i <= 999; i++)
            {
                int num2 = i+diff;
                int num3 = num2 + diff;
                if (IsNumber(i) && IsNumber(num2) && IsNumber(num3) && num3<=999 && CalculateDigit(i) + CalculateDigit(num2)+ CalculateDigit(num3) == sum &&
                   num2-i ==diff && num3-num2 == diff)
                {
                    
                    Console.WriteLine("{0}{1}{2}", i, num2, num3);
                    counter++;
                }
            }
                if (counter==0)
                {
                    Console.WriteLine("No");
                }
                
            }
        
        private static int CalculateDigit(int n)
        {
            int sum=0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;

        }
        private static bool IsNumber(int n)
        {
            string numString = n.ToString();
            foreach (var digit in numString)
            {
                if (digit < '5' || digit > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }

