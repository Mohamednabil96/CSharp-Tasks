namespace SchoolApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Add a student and display data.");
                Console.WriteLine("2. Add a group of students and display data.");
                Console.WriteLine("0. Exit.");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student student = new Student();

                        Console.WriteLine("Enter SSN:");
                        student.SetSsn(Console.ReadLine());

                        Console.WriteLine("Enter First Name:");
                        student.SetFirstName(Console.ReadLine());

                        Console.WriteLine("Enter Last Name:");
                        student.SetLastName(Console.ReadLine());

                        Console.WriteLine("Enter Age:");
                        student.SetAge(int.Parse(Console.ReadLine()));

                        Console.WriteLine("Enter Address:");
                        student.SetAddress(Console.ReadLine());

                        Console.WriteLine("Student data:");
                        student.PrintOnConsole();
                        
                        break;

                    case 2:
                        Console.WriteLine("Enter the number of students:");
                        int numberOfStudents = int.Parse(Console.ReadLine());
                        Student[] students = new Student[numberOfStudents];

                        for (int i = 0; i < numberOfStudents; i++)
                        {
                            Console.WriteLine($"Enter data of Student {i + 1}:");
                            Student s = new Student();

                            Console.WriteLine("Enter SSN:");
                            s.SetSsn(Console.ReadLine());

                            Console.WriteLine("Enter First Name:");
                            s.SetFirstName(Console.ReadLine());

                            Console.WriteLine("Enter Last Name:");
                            s.SetLastName(Console.ReadLine());

                            Console.WriteLine("Enter Age:");
                            s.SetAge(int.Parse(Console.ReadLine()));

                            Console.WriteLine("Enter Address:");
                            s.SetAddress(Console.ReadLine());

                            students[i] = s;
                        }

                        Console.WriteLine("Students data:");
                        foreach (Student s in students)
                        {
                            Console.WriteLine(s.PrintAsString());
                        }

                        //Or

                        //for (int i = 0; i < numberOfStudents; i++)
                        //{
                        //    student.PrintOnConsole()
                        //}
                        //break;
                        
                    case 0:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
    struct Student
    {
        //Student Fields
        public string ssn;
        public string firstName;
        public string lastName;
        public int age;
        public string address;


        // Student Methods
        // 1- Setters
        public void SetSsn(string ssn)
        {
            this.ssn = ssn;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetAge(int age)
        {
            if (age < 23 || age > 45)
            {
                throw new ArgumentException("Age must be between 23 and 45.");
            }
            this.age = age;
        }

        public void SetAddress(string address)
        {
            if (address != "cairo" && address != "alex" && address != "giza")
            {
                throw new ArgumentException("Address must be Cairo, Alex or Giza.");
            }
            this.address = address;
        }

        // 2- Getters
        public string GetSsn()
        {
            return ssn;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetAddress()
        {
            return address;
        }

    // 3- Print methods
    // 3a- void PrintOnConsole()
    public void PrintOnConsole()
        {
            Console.WriteLine($"SSN: {ssn}");
            Console.WriteLine($"Full Name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }

    // 3b- string PrintAsString()
    public string PrintAsString()
        {
            return $"SSN: {ssn}, Full Name: {firstName} {lastName}, Age: {age}, Address: {address}";
        }
    }

