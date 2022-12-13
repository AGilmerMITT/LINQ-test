using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_test.Classes
{
    internal class Classroom
    {
        private static int _nextId = 1;
        public int Id { get; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public HashSet<ClassroomStudent> ClassroomStudents { get; set; } = new();

        public Classroom() { }
        public Classroom(Course course, Teacher teacher, HashSet<ClassroomStudent> students = null!)
        {
            Id = _nextId++;
            Course = course;
            Teacher = teacher;
            ClassroomStudents = students ?? ClassroomStudents;
        }
    }
}
