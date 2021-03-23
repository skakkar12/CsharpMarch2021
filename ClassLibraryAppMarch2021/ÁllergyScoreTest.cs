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
    public class ÁllergyScoreTest
    {

        [TestMethod]
        public void FindAllergy(int score)
        {
            //Arrange
            AllergiesValues allergies = new AllergiesValues();
            Dictionary<string, int> Result;
            AllergyData data = new AllergyData();
            score = 34;

            //Act
            data.FindPersonAllergy(score);
            //Result = allergies.AllergyChart();


            //Assert
             
        }

        public void isAllergicTo(string prodname)
        {
            //Arrange
            AllergiesValues allergies = new AllergiesValues();
            Dictionary<string, int> Result;
            AllergyData data = new AllergyData();
             prodname = "eggs";

            //Act
            data.isAllergyTo(prodname);

            //Assert

        }

    }
}
