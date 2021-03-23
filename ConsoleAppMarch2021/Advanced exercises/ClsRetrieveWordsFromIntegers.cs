using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Advanced_exercises
{
    public class ClsRetrieveWordsFromIntegers
    {
        public static void Main()
        {
            ClsRetrieveWordsFromIntegers.FindStrings2FromNos();
        }

        private static void FindStrings2FromNos()
        {
            string result;
            Dictionary<int, string> container = new Dictionary<int, string>();
            container.Add(20, "twenty");
            container.Add(21, "twenty one");
            container.Add(22, "twenty two");
            container.Add(23, "twenty three");
            container.Add(24, "twenty four");
            container.Add(25, "twenty five");

            foreach (KeyValuePair<int, string> item in container)
            {
                Console.WriteLine("Key :{0}, value:{1}", item.Key, item.Value);
            }
        }
    }
}
