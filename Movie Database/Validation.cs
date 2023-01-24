using System;
namespace Movie_Database
{
	public class Validation
	{
        //----
        public static int GetUserNumber()
        {
            int result = 0;
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. View All");
            Console.WriteLine("2. View by Catagory");

            while (true)
            {
                while (int.TryParse(Console.ReadLine(), out result) == false)
                {
                    Console.Write("Invalid Input. Try again: ");
                }
                if (result == 1 || result == 2)
                {
                    break;
                }
                else
                {
                    Console.Write("Not an option. Try again: ");
                }
            }

            return result;
        }

        //----
        public static bool GetContinue(string msg)
        {
            bool result = true;
            while (true)
            {
                Console.Write($"{msg} (y/n): ");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    result = true;
                    Console.Clear();
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            return result;
        }
    }
}

