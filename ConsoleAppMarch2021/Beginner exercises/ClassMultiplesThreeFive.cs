using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Basic_exercises
{
    interface IClassMultiplesThreeFive
    {
        List<List<string>> FindMultiples(int n);
    }
    public class ClassMultiplesThreeFive : IClassMultiplesThreeFive
    {

        public List<List<string>> FindMultiples(int n )
        {
            int CountThreeMultiple=0, CountFiveMultiple = 0;
            StringBuilder stringThreeMultiples = new StringBuilder();
            StringBuilder stringFiveMultiples = new StringBuilder();
            string[] arrystr; string[] arrystr1;
            List<List<string>> CombineListString = new List<List<string>>();


            for (int i = 1; i <= n; i++)
            {
                if (i%3==0)
                {
                    CountThreeMultiple += 1;
                    stringThreeMultiples.Append(i);
                    stringThreeMultiples.Append(",");
                }
                else if (i%5==0)
                {
                    CountFiveMultiple += 1;
                    stringFiveMultiples.Append(i);
                    stringFiveMultiples.Append(",");
                }

                // create string, then arrya and list<>
             
                
            }
            string resultstring = stringThreeMultiples.ToString();
            arrystr = resultstring.Split(',');
            List<string> firstList = arrystr.ToList<string>();


            // create string, then arrya and list<>
            string resultstringsecond = stringFiveMultiples.ToString();
            arrystr1 = resultstringsecond.Split(',');
            List<string> SecondList = arrystr1.ToList<string>();

            CombineListString.Add(firstList);
            CombineListString.Add(SecondList);
            return CombineListString;
        }
        public static void Main(string[] args)
        {
            List<List<string>> lststring = new List<List<string>>();
            ClassMultiplesThreeFive multiples = new ClassMultiplesThreeFive();
            lststring =multiples.FindMultiples(150);
        }
    }
}