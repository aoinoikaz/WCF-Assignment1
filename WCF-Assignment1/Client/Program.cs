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
            WcfAssignmentService.ServiceClient client = new WcfAssignmentService.ServiceClient();


            bool exit = false;

            do
            {
                Console.WriteLine("---------- WCF Assignment 1 ---------- \n");

                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit \n");

                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
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
}
