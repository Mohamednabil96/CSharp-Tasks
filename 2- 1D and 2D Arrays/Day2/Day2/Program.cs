namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D Arrays

            // #region


            // int[] arr = new int[10];

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine($"Enter value {i + 1} : ");
            //     arr[i] = int.Parse(Console.ReadLine());
            // }

            // int min = arr[0];
            // int max = arr[1];
            // for (int i = 0;i < arr.Length;i++)
            // {
            //     if (arr[i] < min)
            //     {
            //         min = arr[i];
            //     }
            //     if (arr[i] > max) { 
            //     max = arr[i];
            //     }   
            // }

            // Console.WriteLine($"Minimum Value : {min}");
            // Console.WriteLine($"Maximum Value : {max}");

            //#endregion




            //#region

            //int[] arr = new int[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter value {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 9 - i; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}

            //Console.Write("Sorted array: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("{0} ", arr[i]);
            //}
            //Console.WriteLine();


            //#endregion



            //#region

            //int[] arr = new int[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter value {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Enter a number to search: ");
            //int num = int.Parse(Console.ReadLine());
            //int index = -1;
            //for (int i = 0; i < 10; i++)
            //{
            //    if (arr[i] == num)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //if (index == -1)
            //{
            //    Console.WriteLine("Number not found.");
            //}
            //else
            //{
            //    Console.WriteLine("Number found at index {0}.", index);
            //}


            //#endregion


            // 2D Array 

            //#region
            //char[,] board = new char[9, 9];

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        board[i, j] = ' ';
            //    }
            //}

            //board[4, 4] = 'p';

            //PrintBoard(board);

            //while (true)
            //{
            //    Console.Write("Enter move (up, down, left, right): ");
            //    string move = Console.ReadLine();

            //    switch (move)
            //    {
            //        case "up":
            //            MoveUp(board);
            //            break;
            //        case "down":
            //            MoveDown(board);
            //            break;
            //        case "left":
            //            MoveLeft(board);
            //            break;
            //        case "right":
            //            MoveRight(board);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid move!");
            //            continue;
            //    }

            //    PrintBoard(board);
            //}

            //static void PrintBoard(char[,] board)
            //{
            //    for (int i = 0; i < 9; i++)
            //    {
            //        for (int j = 0; j < 9; j++)
            //        {
            //            Console.Write(board[i, j]);
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //static void MoveUp(char[,] board)
            //{
            //    for (int i = 1; i < 9; i++)
            //    {
            //        for (int j = 0; j < 9; j++)
            //        {
            //            if (board[i, j] == 'p')
            //            {
            //                board[i - 1, j] = 'p';
            //                board[i, j] = ' ';
            //                return;
            //            }
            //        }
            //    }
            //}

            //static void MoveDown(char[,] board)
            //{
            //    for (int i = 7; i >= 0; i--)
            //    {
            //        for (int j = 0; j < 9; j++)
            //        {
            //            if (board[i, j] == 'p')
            //            {
            //                board[i + 1, j] = 'p';
            //                board[i, j] = ' ';
            //                return;
            //            }
            //        }
            //    }
            //}

            //static void MoveLeft(char[,] board)
            //{
            //    for (int i = 0; i < 9; i++)
            //    {
            //        for (int j = 1; j < 9; j++)
            //        {
            //            if (board[i, j] == 'p')
            //            {
            //                board[i, j - 1] = 'p';
            //                board[i, j] = ' ';
            //                return;
            //            }
            //        }
            //    }
            //}

            //static void MoveRight(char[,] board)
            //{
            //    for (int i = 0; i < 9; i++)
            //    {
            //        for (int j = 7; j >= 0; j--)
            //        {
            //            if (board[i, j] == 'p')
            //            {
            //                board[i, j + 1] = 'p';
            //                board[i, j] = ' ';
            //                return;
            //            }
            //        }
            //    }
            //}
            //#endregion

            // Bonus

            //#region
            //Console.Write("Please, enter your birthday year: ");
            //int birthYear = int.Parse(Console.ReadLine());

            //Console.Write("Please, enter your birthday month: ");
            //int birthMonth = int.Parse(Console.ReadLine());

            //Console.Write("Please, enter your birthday day: ");
            //int birthDay = int.Parse(Console.ReadLine());

            //DateTime currentDate = DateTime.Now;

            //TimeSpan difference = currentDate - new DateTime(birthYear, birthMonth, birthDay);

            //int years = (int)(difference.TotalDays / 365.25);
            //int months = (int)((difference.TotalDays % 365.25) / 30.4375);
            //int days = (int)(difference.TotalDays % 30.4375);

            //Console.WriteLine($"You have lived for {years} years, {months} months, and {days} days.");

            //#endregion

        }
    }
}