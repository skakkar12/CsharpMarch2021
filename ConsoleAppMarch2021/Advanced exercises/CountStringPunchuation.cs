using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppMarch2021.Advanced_exercises
{
    public class CountStringPunchuation
    {
        public static void Main(string[] args)
        {


        }

        public int countchars(string str)
        {
            char[] PunchuationChars = { '!', ',', ';'};
            int countchars = 0;
            StringBuilder strg = new StringBuilder();

            char[] arry = str.ToCharArray();

            
            

            for (int i = 0; i < PunchuationChars.Length; i++)
            {
                arry.Count(a => a == PunchuationChars[i]);

                arry.Select(a => a == PunchuationChars[i]);
            }


            
            for (int i = 0; i < arry.Length; i++)
            {
                if (PunchuationChars.Contains(arry[i]))
                {
                    strg.Append(arry[i]);
                    strg.Append("+");
                    countchars++;
                }
            }

            return countchars;
        }
    }
}
