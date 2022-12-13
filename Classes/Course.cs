using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_test.Classes
{
    internal class Course
    {
        public static int _nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public HashSet<Classroom> Classrooms { get; set; } = new();
        public int MinimumPassingGrade { get; set; }

        public Course() { }
        public Course(string name, int credits, int minimumPassingGrade = 50, HashSet<Classroom> classrooms = null!)
        {
            Id = _nextId++;
            Name = name;
            Credits = credits;
            Classrooms = classrooms ?? Classrooms;
            MinimumPassingGrade = minimumPassingGrade;
        }
    }
}
