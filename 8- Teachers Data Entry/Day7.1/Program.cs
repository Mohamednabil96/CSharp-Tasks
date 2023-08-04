using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Console.Write("Enter number of teachers: ");
            int numTeachers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numTeachers; i++)
            {
                Console.WriteLine("Enter information for a teacher:");
                Console.Write("Id: ");
                int teacherId = int.Parse(Console.ReadLine());
                Console.Write("First name: ");
                string teacherFirstName = Console.ReadLine();
                Console.Write("Last name: ");
                string teacherLastName = Console.ReadLine();
                Console.Write("Address: ");
                string teacherAddress = Console.ReadLine();
                Console.Write("Age: ");
                int teacherAge = int.Parse(Console.ReadLine());
                Console.Write("Salary: ");
                double teacherSalary = double.Parse(Console.ReadLine());
                Console.Write("Subjects (separated by commas): ");
                List<string> teacherSubjects = Console.ReadLine().Split(',').ToList();

                var teacher = new Teacher(teacherId, teacherFirstName, teacherLastName, teacherAddress, teacherAge, teacherSalary, teacherSubjects);
                people.Add(teacher);
            }

            Console.Write("Enter number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Enter information for a student:");
                Console.Write("Id: ");
                int studentId = int.Parse(Console.ReadLine());
                Console.Write("First name: ");
                string studentFirstName = Console.ReadLine();
                Console.Write("Last name: ");
                string studentLastName = Console.ReadLine();
                Console.Write("Address: ");
                string studentAddress = Console.ReadLine();
                Console.Write("Age: ");
                int studentAge = int.Parse(Console.ReadLine());
                Console.Write("School year: ");
                int studentSchoolYear = int.Parse(Console.ReadLine());
                Console.Write("Class: ");
                string studentClass = Console.ReadLine();

                var student = new Student(studentId, studentFirstName, studentLastName, studentAddress, studentAge, studentSchoolYear, studentClass);
                people.Add(student);
            }

            Console.WriteLine("\nTeacher(s):");
            foreach (var teacher in people.OfType<Teacher>())
            {
                teacher.Print();
            }
            Console.WriteLine("IsActive: " + people.OfType<Teacher>().Any(t => t.IsActive()));

            Console.WriteLine("\nStudent(s):");
            foreach (var student in people.OfType<Student>())
            {
                student.Print();
            }
            Console.WriteLine("IsActive: " + people.OfType<Student>().Any(s => s.IsActive()));

            Console.ReadLine();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person(int id, string firstName, string lastName, string address, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void SetFullName(string fullName)
        {
            var parts = fullName.Split(' ');
            FirstName = parts[0];
            LastName = parts[1];
        }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string address)
        {
            Address = address;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Id: {Id}, Name: {GetFullName()}, Address: {Address}, Age: {Age}");
        }
    }

    public class Teacher : Person
    {
        public double Salary { get; set; }
        public List<string> Subjects { get; set; }

        public Teacher(int id, string firstName, string lastName, string address, int age, double salary, List<string> subjects)
            : base(id, firstName, lastName, address, age)
        {
            Salary = salary;
            Subjects = subjects;
        }

        public bool IsActive()
        {
            return Subjects.Count > 0;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary: {Salary}, Subjects: {string.Join(", ", Subjects)}");
        }
    }

    public class Student : Person
    {
        public int SchoolYear { get; set; }
        public string Class { get; set; }

        public Student(int id, string firstName, string lastName, string address, int age, int schoolYear, string @class)
            : base(id, firstName, lastName, address, age)
        {
            SchoolYear = schoolYear;
            Class = @class;
        }

        public bool IsActive()
        {
            return !string.IsNullOrEmpty(Class);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"SchoolYear: {SchoolYear}, Class: {Class}");
        }
    }

}
