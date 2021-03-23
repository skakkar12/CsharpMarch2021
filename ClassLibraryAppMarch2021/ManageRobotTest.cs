using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppMarch2021.Advanced_exercises;

namespace ClassLibraryAppMarch2021
{
    public class ManageRobotTest
    {
        ManageRobot manage = new ManageRobot();

        public void RobotBoot()
        {
            //Arrange
            string result = manage.GenerateName();

            //Act


            //Assert

        }

        public void SetName()
        {

        }

        public void RobotReset()
        {
            Robot rbt = new Robot();

            if (!rbt.RobotName.Equals(null))
            {
                manage.NameWipe();
            }
            manage.NameWipe();

        }
    }
}