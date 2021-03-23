using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Basic_exercises
{
    public class Displaysqrt
    {
        public static void Main(string[] args)
        {
            int num; double result;

            Console.Write("Enter number");

            try
            {
                num = Convert.ToInt32(Console.ReadLine());

                result = Math.Sqrt(num);
            }
            catch (Exception ex)
            {

                Console.WriteLine("The exception is ", ex);
            }
        }
    }
}
