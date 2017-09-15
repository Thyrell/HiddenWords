using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenWordsLibrary
{
    public class Functions
    {
        public static String StringToHex(string input)
        {
            // output will be seperated by hypens and in a string format until i have a better way to run this. 
            byte[] bytes = Encoding.ASCII.GetBytes(input); // populates an array  with the byte values
            string Output = BitConverter.ToString(bytes);
            return Output;
        }
    }
}
