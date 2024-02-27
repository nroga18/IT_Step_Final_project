using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Students
{
    internal class StudentManager
    {
        public List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void DisplayAllStudents()
        {
            students.ForEach(Console.WriteLine);
        }
        public Student FindStudentByNumber(int number) 
        {
            var student = students.Find(x => x.RollNumber == number);
            return student;
        }
        public void UpdateGrade(int number, char newGrade)
        {
            var student = students.Find(x => x.RollNumber == number);
            if(student != null)
            {
               student.Grade = newGrade;
            }
        }
    }
}
