namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = -1,
             y = 4,
             z = 6;
            int result = x + y * z; //-1+4*6
            Console.WriteLine(result); //23

            int x = 35,
                y = 5,
                z = 7;
            int result = (x + y) % z; //(35+5)%7 --> 40 %7
            Console.WriteLine(result); //5

            int x = 14,
                y = -4,
                z = 6,
                e = 11;
            int result = x + y * (float)z / e; //14 + -4 * 6 /11
            Console.WriteLine(result); //11.818181

            int x = 2,
                y = 15,
                z = 6,
                e = 1,
                f = 7;
            int result = x + y / (float)z * e - f % x; // 2 +15 / 6 * 1 - 7 %2
            Console.WriteLine(result); // 3.5

            int x = 2,
                y = (x++) + x;
            Console.WriteLine(x); // 3
            Console.WriteLine(y); // 5

            int x = 2; int y = 3; int z = 4;
            Console.WriteLine(x < y); //True
            Console.WriteLine(y < z); //True
            Console.WriteLine(z == x); //False
            Console.WriteLine(z != y); //True
            Console.WriteLine((z >= x) && (z <= y)); //False
            Console.WriteLine((y >= x) && (y <= z)); //True




        }
    }
}