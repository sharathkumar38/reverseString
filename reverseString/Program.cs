using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            Console.WriteLine("String before reversing is -" + str);
            ReverseString(str);
            Console.ReadLine();
        }

        internal static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedString = new string(charArray);
            Console.WriteLine("String after reversing is "+ reversedString);
        }
    }
}
