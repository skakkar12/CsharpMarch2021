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
    public class SchoolRosterTest
    {
        [TestMethod]
        public void AddStudentToRoster()
        {
            //Add a student's name to the roster for a grade
            //"Add Jim to grade 2."
            //"OK."
            //arrange
            Student newstudent = new Student { Id = 5, Name = "Jim", Grade = "2" };
            SchoolRoster roster = new SchoolRoster();


            //act
            string result = roster.AddStudent(newstudent);

            //assert


        }


        [TestMethod]
        public void GetListStudentsGrade2()
        {
            //arrange
            SchoolRoster roster = new SchoolRoster();
            List<Student> lstresult;

            //act
            lstresult = roster.GetGrade2ListStudent();
            //assert

        }


        [TestMethod]
        public void GetGrade2Students()
        {
            //arrange
            SchoolRoster roster = new SchoolRoster();
            List<Student> lstresult;

            //act
            lstresult = roster.GetGrade2ListStudent();
            //assert


        }

        [TestMethod]
        public void GetSortedlistStudents()
        {
            //arrange
            SchoolRoster roster = new SchoolRoster();
            List<Student> lstresult;

            //act
            lstresult = roster.GetGrade2ListStudent();
            //assert

        }

    }
}