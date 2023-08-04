namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            const int maxStudents = 10;
            int numOfStudents = 0;
            Student[] students = new Student[maxStudents];

            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Add a student.");
                Console.WriteLine("2. Add a group of students (3 to 10 students).");
                Console.WriteLine("3. Print student data.");
                Console.WriteLine("0. Exit.");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (numOfStudents < maxStudents)
                        {
                            Student student = new Student();

                            Console.WriteLine("Enter SSN: ");
                            student.SSN = Console.ReadLine();

                            Console.WriteLine("Enter name: ");
                            student.Name = Console.ReadLine();

                            Console.WriteLine("Enter age: ");
                            student.Age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter address: ");
                            student.Address = Console.ReadLine();

                            students[numOfStudents] = student;
                            numOfStudents++;

                            if (numOfStudents == maxStudents || numOfStudents % 10 == 0)
                            {
                                Console.WriteLine("10 students data has been submitted.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Maximum number of students reached.");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter number of students to add (3 to 10): ");
                        int numOfStudentsToAdd = int.Parse(Console.ReadLine());

                        if (numOfStudentsToAdd < 3 || numOfStudentsToAdd > 10)
                        {
                            Console.WriteLine("Invalid number of students.");
                        }
                        else
                        {
                            for (int i = 0; i < numOfStudentsToAdd; i++)
                            {
                                if (numOfStudents < maxStudents)
                                {
                                    Student student = new Student();

                                    Console.WriteLine("Enter SSN: ");
                                    student.SSN = Console.ReadLine();

                                    Console.WriteLine("Enter name: ");
                                    student.Name = Console.ReadLine();

                                    Console.WriteLine("Enter age: ");
                                    student.Age = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter address: ");
                                    student.Address = Console.ReadLine();

                                    students[numOfStudents] = student;
                                    numOfStudents++;
                                }
                                else
                                {
                                    Console.WriteLine("Maximum number of students reached.");
                                }
                            }

                            if (numOfStudents == maxStudents || numOfStudents % 10 == 0)
                            {
                                Console.WriteLine("10 students data has been submitted.");
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("Enter SSN to search: ");
                        string ssn = Console.ReadLine();

                        for (int i = 0; i < numOfStudents; i++)
                        {
                            if (students[i].SSN == ssn)
                            {
                                Console.WriteLine("Name: " + students[i].Name);
                                Console.WriteLine("Age: " + students[i].Age);
                                Console.WriteLine("Address: " + students[i].Address);
                                break;
                            }

                            if (i == numOfStudents - 1)
                            {
                                Console.WriteLine("Student not found.");
                            }
                        }

                        break;

                    case 0:
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 0);
        }
    }

    public class Student
    {
        private static int counter = 0;
        private string ssn;
        private string name;
        private int age;
        private string address;

        public Student()
        {
            counter++;

            if (counter % 10 == 0)
            {
                Console.WriteLine("10 students data has been submitted.");
            }

            ssn = "";
            name = "";
            age = 0;
            address = "";
        }

        public Student(string _ssn, string _name, int _age, string _address)
        {
            counter++;

            if (counter % 10 == 0)
            {
                Console.WriteLine("10 students data has been submitted.");
            }

            ssn = _ssn;
            name = _name;
            age = _age;
            address = _address;
        }

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void Print()
        {
            Console.WriteLine($"SSN: {ssn}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}

//namespace FIFO
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ShiftQueue q = new ShiftQueue();
//            q.Enqueue(10);
//            q.Enqueue(20);
//            q.Enqueue(30);
//            Console.WriteLine(q.Dequeue());
//            Console.WriteLine(q.Dequeue());
//            Console.WriteLine(q.Dequeue());
//        }

//        class ShiftQueue
//        {
//            private int[] queue;
//            private int front;
//            private int rear;

//            public ShiftQueue()
//            {
//                queue = new int[100];
//                front = 0;
//                rear = 0;
//            }

//            public bool IsEmpty()
//            {
//                return (front == rear);
//            }

//            public int Size()
//            {
//                return (rear - front);
//            }

//            public void Enqueue(int item)
//            {
//                queue[rear++] = item;
//            }

//            public int Dequeue()
//            {
//                if (IsEmpty())
//                {
//                    return -1;
//                }
//                int item = queue[front++];
//                if (front == rear)
//                {
//                    front = 0;
//                    rear = 0;
//                }
//                return item;
//            }
//        }
//    }
//}