using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppMarch2021.Advanced_exercises;

namespace ClassLibraryAppMarch2021
{
    [TestClass]
    public class CountpunchuationChas
    {
      

        [TestMethod]
        public int countPunchationChars()
        {

            //Arrange
            string[] PunchuationChars = {"!", ",",";", ".","?","-", "\\", ":" };
            CountStringPunchuation cpunch = new CountStringPunchuation();
            string inputstr = null;

            //Act
            int result= cpunch.countchars(inputstr);


            //Assert
            return 1;
        }
    }
}
