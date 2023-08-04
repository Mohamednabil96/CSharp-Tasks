namespace Day6Lab
{
    internal class Program
    {
static void Main(string[] args)
        {
            List<Teacher> teachers = new List<Teacher>();
            List<Student> students = new List<Student>();
            List<Subject> subjects = new List<Subject>();
            List<SchoolYear> schoolYears = new List<SchoolYear>();

            while (true)
            {
                Console.WriteLine("Which data type do you want to create?");
                Console.WriteLine("1. Teacher");
                Console.WriteLine("2. Student");
                Console.WriteLine("3. Subject");
                Console.WriteLine("4. School Year");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        CreateTeacher(teachers, subjects);
                        break;
                    case 2:
                        CreateStudent(students, schoolYears);
                        break;
                    case 3:
                        CreateSubject(subjects);
                        break;
                    case 4:
                        CreateSchoolYear(schoolYears, subjects);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            Console.WriteLine("Teachers:");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.PrintInfo());
            }

            Console.WriteLine("Students:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.PrintInfo());
            }

            Console.WriteLine("Subjects:");
            foreach (Subject subject in subjects)
            {
                Console.WriteLine(subject.ToString());
            }

            Console.WriteLine("School Years:");
            foreach (SchoolYear schoolYear in schoolYears)
            {
                Console.WriteLine(schoolYear.ToString());
            }

            Console.ReadLine();
        }

        static void CreateTeacher(List<Teacher> teachers, List<Subject> subjects)
        {
            Console.WriteLine("Enter teacher ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter teacher first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter teacher last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter teacher address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter teacher age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter teacher salary:");
            double salary = double.Parse(Console.ReadLine());

            List<Subject> teacherSubjects = new List<Subject>();

            while (true)
            {
                Console.WriteLine("Enter subject ID to add to teacher (or 0 to finish):");
                int subjectId = int.Parse(Console.ReadLine());

                if (subjectId == 0)
                {
                    break;
                }

                Subject subject = subjects.FirstOrDefault(s => s.Id == subjectId);

                if (subject != null)
                {
                    teacherSubjects.Add(subject);
                }
                else
                {
                    Console.WriteLine("Invalid subject ID");
                }
            }

            Teacher teacher = new Teacher(id, firstName, lastName, address, age, salary, teacherSubjects);
            teachers.Add(teacher);
        }

        static void CreateStudent(List<Student> students, List<SchoolYear> schoolYears)
        {
            Console.WriteLine("Enter student ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter student last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter student address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter student age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student grade:");
            int grade = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student school year ID:");
            int schoolYearId = int.Parse(Console.ReadLine());

            SchoolYear schoolYear = schoolYears.FirstOrDefault(s => s.Id == schoolYearId);
        }

        static void CreateSubject(List<Subject> subjects)
        {
            Console.WriteLine("Enter subject ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter subject name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter subject description:");
            string description = Console.ReadLine();

            Subject subject = new Subject(id, name, description, 100, 50);
            subjects.Add(subject);
        }


        static void CreateSchoolYear(List<SchoolYear> schoolYears, List<Subject> subjects)
        {
            Console.WriteLine("Enter school year ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter school year name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter school year start year:");
            int startYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter school year end year:");
            int endYear = int.Parse(Console.ReadLine());

            List<Subject> schoolYearSubjects = GetSubjectsFromInput(subjects);

            SchoolYear schoolYear = new SchoolYear(id, name, endYear - startYear, schoolYearSubjects);

            schoolYears.Add(schoolYear);
        }

        static List<Subject> GetSubjectsFromInput(List<Subject> subjects)
        {
            Console.WriteLine("Enter subject IDs for school year (comma-separated):");
            string subjectIdsString = Console.ReadLine();
            string[] subjectIdsArray = subjectIdsString.Split(',');

            List<Subject> schoolYearSubjects = new List<Subject>();

            foreach (string subjectIdString in subjectIdsArray)
            {
                int subjectId = int.Parse(subjectIdString);
                Subject subject = subjects.FirstOrDefault(s => s.Id == subjectId);

                if (subject != null)
                {
                    schoolYearSubjects.Add(subject);
                }
                else
                {
                    Console.WriteLine($"Invalid subject ID '{subjectIdString}'");
                }
            }

            return schoolYearSubjects;
        }

    }
}