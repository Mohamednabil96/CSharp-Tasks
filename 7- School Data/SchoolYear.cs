using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class SchoolYear
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public List<Subject> Subjects { get; set; }

        public SchoolYear(int id, string name, int duration, List<Subject> subjects)
        {
            Id = id;
            Name = name;
            Duration = duration;
            Subjects = subjects;
        }

        public int GetId() { return Id; }

        public string GetName() { return Name; }

        public int GetDuration() { return Duration; }

        public List<Subject> GetSubjects() { return Subjects; }

        public override string ToString()
        {
            string subjectsString = string.Join(", ", Subjects.Select(s => s.Name));

            return $"School Year Id: {Id}\nSchool Year Name: {Name}\nDuration: {Duration} days\nSubjects: {subjectsString}\n";
        }
    }
}
