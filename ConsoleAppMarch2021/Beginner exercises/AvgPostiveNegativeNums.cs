using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Beginner_exercises
{
    interface IAvgPostiveNegativeNums
    {
        void AverageNums(int[] data);
    }
    class AvgPostiveNegativeNums:IAvgPostiveNegativeNums
    {
        public static void Main(string[] args)
        {
            int Sum = 0, num;
            do
            {
                Console.Write("enter number");
                num =Convert.ToInt32(Console.ReadLine());

                Sum += num;

            } while (Convert.ToString(num).Equals("end"));


        }

        public void AverageNums(int[] data)
        {
            int countPositive = 0;
            int SumPositive = 0;
            int countNegative = 0;
            int SumNegative = 0;
            

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i]>0)
                {
                    countPositive += 1;
                    SumPositive += data[i];
                }
                else
                {
                    SumNegative += data[i];
                    countNegative += 1;
                }

                Console.WriteLine("Average positive numbers: ", SumPositive / countPositive);
                Console.WriteLine("Average positive numbers: ", SumNegative/countNegative);
            }
        }
    }
}
