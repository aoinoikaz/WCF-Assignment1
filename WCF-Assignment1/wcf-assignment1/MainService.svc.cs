using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MainService : IService
    {
        public int CalculateSumOfDigits(int number)
        {
            throw new NotImplementedException();
        }

        public string ConvertToHTMLTag(string tag, string data)
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int number)
        {
            throw new NotImplementedException();
        }

        public string ReverseString(string data)
        {
            throw new NotImplementedException();
        }

        public List<int> SortNumbers(SortType type, List<int> numbers)
        {
            throw new NotImplementedException();
        }
    }
}
