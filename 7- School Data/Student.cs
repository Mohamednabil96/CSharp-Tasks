using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class Student : Person
    {
        private int schoolYear;
        private string @class;

        public Student(int id, string fname, string lname, string address, int age, int schoolYear, string @class) : base(id, fname, lname, address, age)
        {
            this.schoolYear = schoolYear;
            this.@class = @class;
        }

        public int SchoolYear
        {
            get { return schoolYear; }
            set { schoolYear = value; }
        }

        public string Class
        {
            get { return @class; }
            set { @class = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"School Year: {schoolYear}, Class: {@class}";
        }
    }
}
