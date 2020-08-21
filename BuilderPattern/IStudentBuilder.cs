using System;

namespace BuilderPattern
{
    public interface IStudentBuilder
    {
        IStudentBuilder AddId(int id);
        IStudentBuilder AddName(string name);
        IStudentBuilder AddClass(string className);
        Student Build();
    }
}