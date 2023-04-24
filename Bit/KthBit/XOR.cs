using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthBit
{
    internal class XOR
    {
        public static void DisplayBinaryofanumber(int n)
        { 
            int b = 2;
            string binaryForm = Convert.ToString(n, b);
            Console.WriteLine(binaryForm);
        }
    }
}
