using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Advanced_exercises
{
    public class AllergiesValues
    {
        public Dictionary<string, int> AllergyChart()
        {
            Dictionary<string, int> allergen = new Dictionary<string, int>();
            allergen.Add("eggs", 1);
            allergen.Add("peanuts", 2);
            allergen.Add("shellfish", 4);
            allergen.Add("strawberries", 8);
            allergen.Add("tomatoes", 16);
            allergen.Add("chocolate", 32);
            allergen.Add("pollen", 64);
            allergen.Add("cats", 128);

            return allergen;
        }
        public static void Main(string[] args)
        {
        }
    }

    public class AllergyData
    {
        AllergiesValues values = new AllergiesValues();
        Dictionary<string, int> resultchart;
        public string FindPersonAllergy(int score)
        {
            resultchart = values.AllergyChart();
            string foodProduct=null;

            foreach (KeyValuePair<string, int> pair in resultchart)
            {
                if (pair.Value==score)
                {
                    foodProduct = pair.Key.ToString();
                }
            }
            return foodProduct; 
        }


        public string isAllergyTo(string isAllergyTo)
        {
            resultchart = values.AllergyChart();
            string prodname=null;

            if (resultchart.ContainsKey(isAllergyTo))
            {
                prodname = resultchart["isAllergyTo"].ToString();
            }

            return prodname;
        }
    }
}