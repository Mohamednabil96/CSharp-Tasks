using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class Teacher : Person
    {
        public double Salary { get; set; }
        public List<Subject> Subjects { get; set; }

        public Teacher(int id, string fname, string lname, string address, int age, double salary, List<Subject> subjects) : base(id, fname, lname, address, age)
        {
            Salary = salary;
            Subjects = subjects;
        }

        public double GetSalary()
        {
            return Salary;
        }

        public List<Subject> GetSubjects()
        {
            return Subjects;
        }

        public override string PrintInfo()
        {
            string subjectsString = string.Join(", ", Subjects.Select(s => s.Name));

            return base.PrintInfo() + $"Salary: {Salary}, Subjects: {subjectsString}";
        }
    }
}
