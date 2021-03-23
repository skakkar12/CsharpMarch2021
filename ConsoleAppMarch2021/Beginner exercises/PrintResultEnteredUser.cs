using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Basic_exercises
{
    interface IPrintResultEnteredUser
    {
        int EnterPrintNumbers(int a, int b, int c);
        void CreateTableMultiplicationNumber(int n);
    }
    public class PrintResultEnteredUser: IPrintResultEnteredUser
    {

        //public static void Main(String[] args)
        //{

        //}

        public int EnterPrintNumbers(int a, int b, int c)
        {
            try
            {
                if (!a.Equals(0) && !b.Equals(0) && !c.Equals(0))
                {
                    return a * b * c;
                }
            }
            catch (Exception ex)
            {

                Console.Write("divide by zero exception " + ex.Message);
            }
            return 0;

        }

        public void CreateTableMultiplicationNumber(int n)
        {

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("The result is {0} * {1} ={2} ", n, i, n * i);
                }
            }
            catch (Exception ex)
            {

                Console.Write("Theere is exception ", ex.Message);
            }
        }
    }
}
