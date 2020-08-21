using System;

namespace BuilderPattern
{
    public class StudentBuilder : IStudentBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

        public StudentBuilder()
        {

        }
        public IStudentBuilder AddClass(string className)
        {
            this.Class = className;
            return this;
        }

        public IStudentBuilder AddId(int id)
        {
            this.Id = id;
            return this;
        }

        public IStudentBuilder AddName(string name)
        {
            this.Name = name;
            return this;
        }

        public Student Build()
        {
            var student = new Student(
                this.Id,
                this.Name,
                this.Class
            );
            return student;
        }
    }
}