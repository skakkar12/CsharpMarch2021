using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppMarch2021.Advanced_exercises
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
    }
    public class SchoolRoster
    {

        List<Student> LstStudent = new List<Student>
        {
            new Student{Id=1, Name="Sona", Grade="2"},
            new Student{Id=2, Name="Sam", Grade="2"},
            new Student{Id=3, Name="carol", Grade="1"},
            new Student{Id=4, Name="Abs", Grade="2"},
        };


        public List<Student> getStudentList()
        {
            return LstStudent;
        }

        public string AddStudent(Student s)
        {
            if (!(getStudentList().Exists(a=>a.Name.Equals("Jim"))))
            {
                LstStudent.Add(s);
            }
            return "OK";
        }

        public List<Student> GetGrade2ListStudent()
        {
            return LstStudent.Where(s => s.Grade.Equals("2")).ToList();

        }

      
    }
}
