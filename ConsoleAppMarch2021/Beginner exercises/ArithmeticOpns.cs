using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Basic_exercises
{
    interface IArithmeticOpns
    {
        int SumNumbers(int a, int b);

        int MulNumbers(int a, int b);
    }
    public class ArithmeticOpns:IArithmeticOpns
    {
        //public static void Main(string[] args)
        //{


        //}

        public int MulNumbers(int a, int b)
        {
            try
            {
                if ((!a.Equals(0) && !b.Equals(0)))
                {
                    return a * b;
                }
            }
            catch (Exception ex)
            {

                Console.Write("there is exception " + ex.Message);
            }
            return 0;
        }

        public int SumNumbers(int a, int b)
        {
            try
            {
                if ((!a.Equals(0) && !b.Equals(0)))
                {
                    return a + b;
                }
            }
            catch (Exception ex)
            {

                Console.Write("there is exception " + ex.Message);
            }
            return 0;
        }
    }
}

