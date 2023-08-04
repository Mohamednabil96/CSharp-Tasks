using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class Person
    {
        protected int Id { get; set; }
        protected string Fname { get; set; }
        protected string Lname { get; set; }
        protected string Address { get; set; }
        protected int Age { get; set; }

        public Person(int id, string fname, string lname, string address, int age)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Address = address;
            Age = age;
        }

        public int GetId() { return Id; }

        public string GetFname() { return Fname; }

        public string GetLname() { return Lname; }

        public string GetAddress() { return Address; }

        public int GetAge() { return Age; }

        public virtual string PrintInfo()
        {
            return $"ID: {Id}, Name: {Fname} {Lname}, Address: {Address}, Age: {Age}";
        }
    }

}
