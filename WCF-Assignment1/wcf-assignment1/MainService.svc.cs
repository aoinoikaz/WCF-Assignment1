using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    public class MainService : IService
    {
        public bool IsPrimeNumber(int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0) 
                return false;

            var step = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= step; i += 2)
            {
                if (number % i == 0)
                { 
                    return false;
                }
            }

            return true;
        }

        public int CalculateSumOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        public string ReverseString(string data)
        {
            string reverse = null;

            for (int i = data.Length - 1; i >= 0; i--)
            {
                reverse += data[i];
            }

            return reverse;
        }

        public string ConvertToHTMLTag(string tag, string data)
        {
            string openingTag = "<" + tag + ">";
            string closingTag = "</" + tag + ">";
            string converted = openingTag + data + closingTag;

            return converted;
        }
        

        public int[] Sort(SortType type, string[] numbers)
        {
            int[] sorted = null;

            if (numbers.Length == 5)
            {
                sorted = new int[5];

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (int.TryParse(numbers[i], out int num))
                    {
                        sorted[i] = num;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            Array.Sort(sorted);

            if (type == SortType.Descending)
            {
                Array.Reverse(sorted);
            }
         
            return sorted;

        }
    }
}
