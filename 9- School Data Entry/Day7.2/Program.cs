using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the capacity of the school: ");
            int capacity = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < capacity; i++)
            {
                Console.Write("Is this person a teacher or student? (t/s): ");
                char choice = Console.ReadLine()[0];

                if (choice == 't')
                {
                    Console.WriteLine("Enter teacher information:");
                    EnterTeacherInfo(out Teacher teacher);
                    people.Add(teacher);
                }
                else
                {
                    Console.WriteLine("Enter student information:");
                    EnterStudentInfo(out Student student);
                    people.Add(student);
                }
            }

            Console.WriteLine("\nTeacher(s):");
            foreach (var teacher in people.OfType<Teacher>())
            {
                teacher.Print();
            }

            Console.WriteLine("\nStudent(s):");
            foreach (var student in people.OfType<Student>())
            {
                student.Print();
            }
        }

        static void EnterTeacherInfo(out Teacher teacher)
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Do you want to add subjects? (y/n) ");
            char choice = Console.ReadLine()[0];

            List<string> subjects = new List<string>();
            if (choice == 'y')
            {
                Console.Write("Subjects (separated by commas): ");
                subjects = Console.ReadLine().Split(',').ToList();
            }

            teacher = new Teacher(id, firstName, lastName, address, age, salary, subjects);
        }

        static void EnterStudentInfo(out Student student)
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("School year: ");
            int schoolYear = int.Parse(Console.ReadLine());

            Console.Write("Do you want to add a class? (y/n) ");
            char choice = Console.ReadLine()[0];

            string @class = null;
            if (choice == 'y')
            {
                Console.Write("Class: ");
                @class = Console.ReadLine();
            }

            student = new Student(id, firstName, lastName, address, age, schoolYear, @class);
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

        public void Print()
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

        public void Print()
        {
            base.Print();
            Console.WriteLine($"SchoolYear: {SchoolYear}, Class: {Class}");
        }
    }

}

