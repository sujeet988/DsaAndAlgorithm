using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaAndAlgorithm.InterViewAsked.KeyPadRecursionQuestions
{
    public class ProgramKeyPad
    {
       public static string[] keypad = {
        "0", "1", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

       public static List<string> GetPhoneNumberCombinations(string phoneNumber)
        {
   
            List<string> combinations = new List<string>();
            GenerateCombinations(phoneNumber, "", combinations, 0);
            return combinations;

        }
        static void GenerateCombinations(string phoneNumber, string current, List<string> combinations, int index)
        {
            if (index == phoneNumber.Length)
            {
                combinations.Add(current);
                return;
            }

            int digit = int.Parse(phoneNumber[index].ToString());
            string letters = keypad[digit];

            for (int i = 0; i < letters.Length; i++)
            {
                string next = current + letters[i];
                GenerateCombinations(phoneNumber, next, combinations, index + 1);
            }
        }
    }
}
