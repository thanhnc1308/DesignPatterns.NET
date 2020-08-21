using System;

namespace BuilderPattern
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string className)
        {
            this.Id = id;
            this.Name = name;
            this.Class = className;
        }

        public override string ToString()
        {
            return $"Student: {this.Id} {this.Name} {this.Class}";
        }
    }
}
