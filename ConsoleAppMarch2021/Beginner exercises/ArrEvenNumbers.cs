using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Beginner_exercises
{
    public class ArrEvenNumbers
    {
        public int[] evenNumbers(int[] data)
        {
            data = new int[10];
            int[] resultarry = new int[10];

            for (int i = 0; i < 10; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < 10; i++)
            {
                if (data[i] %2 == 0)
                {
                    Console.Write("{0} ", data[i]);
                    resultarry[i] = data[i];
                }
            }
            return resultarry;
        }
    }
}