using System;

namespace StallReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stall Reservation System!");
            Console.Write("Enter the number of stalls available: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool[] stalls = new bool[n];

            while (true)
            {
                Console.Write("Enter the first stall number (0 to exit): ");
                int stall1 = Convert.ToInt32(Console.ReadLine());

                if (stall1 == 0)
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                Console.Write("Enter the second stall number (0 to exit): ");
                int stall2 = Convert.ToInt32(Console.ReadLine());

                if (stall2 == 0)
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                
                if (stall1 < 1 || stall1 > n || stall2 < 1 || stall2 > n)
                {
                    Console.WriteLine("Invalid stall number. Please try again.");
                    continue;
                }

          
                if (stalls[stall1 - 1] && stalls[stall2 - 1])
                {
                    Console.WriteLine("Both stalls are already reserved. Please try again.");
                    continue;
                }

                
                if (stalls[stall1 - 1] || stalls[stall2 - 1])
                {
                    Console.WriteLine("The stall is reserved. Please try again.");
                    continue;
                }

                
                stalls[stall1 - 1] = true;
                stalls[stall2 - 1] = true;

                
                Console.WriteLine("Stall status: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(stalls[i] ? "X " : "_ ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using Stall Reservation System!");
        }
    }
}
