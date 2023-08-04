using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FullMark { get; set; }
        public int PassMark { get; set; }

        public Subject(int id, string name, string description, int fullMark, int passMark)
        {
            Id = id;
            Name = name;
            Description = description;
            FullMark = fullMark;
            PassMark = passMark;
        }

        public int GetId() { return Id; }

        public string GetName() { return Name; }

        public string GetDescription() { return Description; }

        public int GetFullMark() { return FullMark; }

        public int GetPassMark() { return PassMark; }

        public override string ToString()
        { return $"Subject Id: {Id}\nSubject Name: {Name}\nDescription: {Description}\nFull Mark: {FullMark}\nPass Mark: {PassMark}\n"; }
    }
}
