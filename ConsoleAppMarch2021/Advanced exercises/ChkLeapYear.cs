using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Advanced_exercises
{
    public class ChkLeapYear
    {
        public static bool isLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
