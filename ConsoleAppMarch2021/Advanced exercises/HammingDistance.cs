using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Advanced_exercises
{
    interface IHammingDistance
    {
        int Distance(string firststand, string secondstand);
    }
    public class HammingDistance:IHammingDistance
    {

        public static void Main(string[] args)
        {
            
        }

        public int Distance(string firststand, string secondstand)
        {
            int distance = 0;

            if (firststand.Length!= secondstand.Length)
            {
                throw new ArgumentException("Arguments do not match");
            }

            for (int i = 0; i < firststand.Length; i++)
            {
                if (firststand[i]!= secondstand[i])
                {
                    distance++;
                }
            }
            return distance;
        }
    }
}