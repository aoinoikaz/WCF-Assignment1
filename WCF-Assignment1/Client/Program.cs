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
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            //var response = client.GetData(100);
            //Console.WriteLine(response);
            //Console.ReadLine();

            

            // prime number

            // sum of digits

            // reverse a string

            // print html tags

            // sort 5 numbers in ascending or descending order

            // write the implementation inside our service and call client

            // client.isPrimeNumber(input)
        }
    }
}
