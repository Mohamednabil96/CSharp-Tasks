    namespace Calculator
    {

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("Please enter two numbers:");
                Console.Write("num1 : ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("num2 : ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Reminder");

                int choice = int.Parse(Console.ReadLine());

                double result = 0;
                switch (choice)
                {
                    case 1:
                        result = MyMath.Add(num1, num2);
                        break;
                    case 2:
                        result = MyMath.Sub(num1, num2);
                        break;
                    case 3:
                        result = MyMath.Mul(num1, num2);
                        break;
                    case 4:
                        result = MyMath.Div(num1, num2);
                        break;
                    case 5:
                        result = MyMath.Remainder(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                Console.WriteLine("The result is: " + result);
            }
        }

        internal class MyMath
        {
            public static double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            public static double Sub(double num1, double num2)
            {
                return num1 - num2;
            }

            public static double Mul(double num1, double num2)
            {
                return num1 * num2;
            }

            public static double Div(double num1, double num2)
            {
                return num1 / num2;
            }

            public static double Remainder(double num1, double num2)
            {
                return num1 % num2;
            }
        }
    }

