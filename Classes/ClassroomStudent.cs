using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_test.Classes
{
    public class ClassroomStudent
    {
        public Classroom Classroom { get; set; }
        public Student Student { get; set; }
        public int Grade { get; set; }

        public ClassroomStudent(Classroom classroom, Student student, int grade = 0)
        {
            Classroom = classroom;
            Student = student;
            Grade = grade;
        }
    }
}
