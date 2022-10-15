using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        bool IsPrimeNumber(int number);

        [OperationContract]
        int CalculateSumOfDigits(int number);

        [OperationContract]
        string ReverseString(string data);

        [OperationContract]
        string ConvertToHTMLTag(string tag, string data);

        [OperationContract]
        List<int> SortNumbers(SortType type, List<int> numbers);
    }
}
