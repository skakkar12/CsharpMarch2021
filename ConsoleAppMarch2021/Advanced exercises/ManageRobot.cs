using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Advanced_exercises
{
    public class Robot
    {
        public int Id { get; set; }

        public string RobotName { get; set; }
    }
    public class ManageRobot
    {
        Robot rabbit = new Robot();
        public string GenerateName()
        {
            Random ran = new Random();
            char firstchar = Char.ToUpper(Convert.ToChar(ran.Next(26)));
            char secondchar = Char.ToUpper(Convert.ToChar(ran.Next(26)));
            string RobotName;

            StringBuilder str = new StringBuilder();
            
            for (int i = 0; i <=2; i++)
            {
                str.Append(ran.Next(100, 200));
            }

            RobotName = firstchar.ToString() + secondchar.ToString() + str.ToString();

            
            rabbit.RobotName = RobotName;
            return RobotName;

        }

        public void NameWipe()
        {
            rabbit.RobotName = null;

        }
    }
}
