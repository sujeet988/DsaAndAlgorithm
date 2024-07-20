namespace BadgeSystem
{

    /*
     * https://leetcode.com/discuss/interview-question/4366572/Atlassian-or-PSE-or-Screening-or-Reject/
     * We are working on a security system for a badged-access room in our company's building.

Given an ordered list of employees who used their badge to enter or exit the room, write a function that returns two collections:

All employees who didn't use their badge while exiting the room - they recorded an enter without a matching exit. (All employees are required to leave the room before the log ends.)

All employees who didn't use their badge while entering the room - they recorded an exit without a matching enter. (The room is empty when the log begins.)

Each collection should contain no duplicates, regardless of how many times a given employee matches the criteria for belonging to it.

records1 = [
["Paul", "enter"],
["Pauline", "exit"],
["Paul", "enter"],
["Paul", "exit"],
["Martha", "exit"],
["Joe", "enter"],
["Martha", "enter"],
["Steve", "enter"],
["Martha", "exit"],
["Jennifer", "enter"],
["Joe", "enter"],
["Curtis", "exit"],
["Curtis", "enter"],
["Joe", "exit"],
["Martha", "enter"],
["Martha", "exit"],
["Jennifer", "exit"],
["Joe", "enter"],
["Joe", "enter"],
["Martha", "exit"],
["Joe", "exit"],
["Joe", "exit"]
]
ENTER W/O EXIT EXIT W/O ENTER
Expected output: ["Steve", "Curtis", "Paul", "Joe"], ["Martha", "Pauline", "Curtis", "Joe"]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}