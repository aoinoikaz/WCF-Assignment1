using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        // After setting console as startup client, we need to link it to the WCF service
        // 

        static void Main(string[] args)
        {
            using (WcfAssignmentService.ServiceClient client = new WcfAssignmentService.ServiceClient())
            {
                bool exit;
                bool next;

                do
                {
                    next = false;
                    exit = false;

                    Console.WriteLine("---------- WCF Assignment 1 ---------- \n");

                    Console.WriteLine("1. Prime number");
                    Console.WriteLine("2. Sum of digits");
                    Console.WriteLine("3. Reverse a string");
                    Console.WriteLine("4. Print HTML tags");
                    Console.WriteLine("5. Sort 5 numbers");
                    Console.WriteLine("6. Exit \n");

                    Console.WriteLine("Enter your choice: ");

                    int input = GetNumber();

                    Console.Clear();

                    if (input != -1)
                    {
                        switch (input)
                        {
                            case 1:
                                do
                                {
                                    Console.WriteLine("---------- Prime Numbers ---------- \n");
                                    Console.WriteLine("Enter a number: ");

                                    int number = GetNumber();

                                    if (number > -1)
                                    {
                                        if (client.IsPrimeNumber(number))
                                        {
                                            Console.WriteLine("\n" + number + " is a prime number!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n" + number + " is not a prime number!");
                                        }

                                        next = true;

                                        Console.WriteLine("\nPress any key to go back to the main menu!");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                }
                                while (!next);
                                break;
                            case 2:
                                do
                                {
                                    Console.WriteLine("---------- Sum of digits ---------- \n");
                                    Console.WriteLine("Enter a number: ");

                                    int number = GetNumber();

                                    if (number > 0)
                                    {
                                        int sum = client.CalculateSumOfDigits(number);
                                        next = true;

                                        Console.WriteLine("\nSum: " + sum);
                                        Console.WriteLine("\nPress any key to go back to the main menu...");
                                        Console.ReadKey();
                                    }

                                    Console.Clear();
                                }
                                while (!next);
                                break;
                            case 3:
                                do
                                {
                                    Console.WriteLine("---------- Reverse a string ---------- \n");
                                    Console.WriteLine("Enter a string: ");

                                    string data = GetString();
                                    string reversed = client.ReverseString(data);

                                    if (reversed != null)
                                    {
                                        next = true;

                                        Console.WriteLine("\nReversed string: " + reversed);
                                        Console.WriteLine("\nPress any key to go back to the main menu...");
                                        Console.ReadKey();
                                    }

                                    Console.Clear();
                                }
                                while (!next);

                                break;
                            case 4:
                                do
                                {
                                    Console.WriteLine("---------- HTML Tag Converter ---------- \n");

                                    Console.WriteLine("Enter an HTML tag: ");
                                    string tag = GetString();

                                    Console.WriteLine("Enter some data: ");
                                    string data = GetString();

                                    string converted = client.ConvertToHTMLTag(tag, data);

                                    if (converted != null)
                                    {
                                        next = true;

                                        Console.WriteLine("\nConverted string: " + converted);
                                        Console.WriteLine("\nPress any key to go back to the main menu...");
                                        Console.ReadKey();
                                    }

                                    Console.Clear();
                                }
                                while (!next);

                                break;
                            case 5:
                                do
                                {
                                    Console.WriteLine("---------- Sort 5 numbers ---------- \n");

                                    Console.WriteLine("Choose the sort type: ");
                                    Console.WriteLine("1. Ascending");
                                    Console.WriteLine("2. Descending");

                                    int sortType = GetNumber();

                                    if (sortType == 1 || sortType == 2)
                                    {

                                        Console.WriteLine("Enter 5 numbers, comma separated:");

                                        string data = GetString();
                                        string[] numbers = data.Split(',');


                                        int[] sorted = client.Sort(sortType == 1 ? WcfAssignmentService.SortType.Ascending : WcfAssignmentService.SortType.Descending, numbers);

                                        next = true;

                                        Console.WriteLine("Sorted: ");
                                        for (int i = 0; i < sorted.Length; i++)
                                        {
                                            Console.WriteLine(sorted[i]);
                                        }

                                        Console.WriteLine("\nPress any key to go back to the main menu...");
                                        Console.ReadKey();

                                    }

                                    Console.Clear();
                                }
                                while (!next);

                                break;
                            case 6:
                                exit = true;
                                break;
                        }
                    }
                    Console.Clear();
                }
                while (!exit);
            }
        }


        static string GetString()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            return input;
        }


        static int GetNumber()
        {
            string input = Console.ReadLine();

            int result = -1;

            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int r))
            {
                result = r;
            }

            return result;
        }
    }
}
