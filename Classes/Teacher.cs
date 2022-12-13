using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_test.Classes
{
    internal class Teacher
    {
        private static int _nextId = 1;
        public int Id { get; }
        public string Name { get; set; }
        public HashSet<Classroom> Classrooms { get; set; } = new();

        public Teacher() { }
        public Teacher(string name, HashSet<Classroom> classrooms = null!)
        {
            Id = _nextId++;
            Name = name;
            Classrooms = classrooms ?? Classrooms;
        }
    }
}
