using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_test.Classes
{
    public class Student
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public string FirstName { get; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public int GradeYear { get; set; }
        public HashSet<ClassroomStudent> ClassroomStudents { get; set; } = new();

        public Student() { }
        public Student(string firstName, string lastName, string nationality, int grade, HashSet<ClassroomStudent> classroomStudents = null!)
        {
            Id = _nextId++;
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            GradeYear = grade;
            ClassroomStudents = classroomStudents ?? ClassroomStudents;
        }
    }
}
