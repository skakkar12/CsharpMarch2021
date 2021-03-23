using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Beginner_exercises
{
    interface IArryReverse
    {
        int[] reverseArry(int[] data);
    }
   public class ArryReverse:IArryReverse
    {
        public static void Main(string[] args)
        {


        }

        public int[] reverseArry(int[] data)
        {
            //Read array
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }


            //Reverse array
            for (int i = data.Length-1; i >=0; i++)
            {
                Console.Write(data[i]);
            }
            return data;
        }
    }
}
