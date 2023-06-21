// See https://aka.ms/new-console-template for more information
using DsaAndAlgorithm.InterViewAsked.KeyPadRecursionQuestions;
Console.WriteLine("Letter Combinations of a Phone Number\r\n");
////https://leetcode.com/problems/letter-combinations-of-a-phone-number/
/*
 * Given a string containing digits from 2-9 inclusive, return all possible letter 
combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below.
Note that 1 does not map to any letters.
Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Input: digits = "2"
Output: ["a","b","c"]
 */

string phoneNumber = "23";
List<string> combinations = ProgramKeyPad.GetPhoneNumberCombinations(phoneNumber);

Console.WriteLine("Possible combinations for " + phoneNumber + ":");
foreach (string combination in combinations)
{
    Console.WriteLine(combination);
}