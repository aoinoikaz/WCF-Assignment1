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
            var response = client.GetData(100);
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
