using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbs = new List<int>();
        int sumOdd = 0;
        int diff = 0;
        int sumEven= 0;
        for (int i = 0; i < 2 * n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbs.Add(number);

        }
        for (int i = 0; i < numbs.Count-1; i += 2)
        {
            int numOdd = Convert.ToInt32(numbs[i]);
            sumOdd += numOdd;
        }
        for (int k = 1; k < numbs.Count; k += 2)
        {
            int numEven = Convert.ToInt32(numbs[k]);
            sumEven += numEven;
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumEven);
        }
        else
        {
            if (sumOdd > sumEven)
            {
                diff = sumOdd - sumEven;
            }
            else
            {
                diff = sumEven-sumOdd;
            }
            Console.WriteLine("No, diff={0}", diff );
        }
    }
}
