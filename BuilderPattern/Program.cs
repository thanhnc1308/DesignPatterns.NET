using System;
using BuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(1, "Name 1", "Class 1");
        System.Console.WriteLine(student1.ToString());
        Student student2 = new StudentBuilder()
                                .AddClass("Class 2")
                                .AddId(2)
                                .AddName("Name 2")
                                .Build();
        System.Console.WriteLine(student2.ToString());
    }
}