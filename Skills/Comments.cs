// create a method that generates a comment for a given skill
using System;

namespace Skills
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = "C# programming";
            string comment = GenerateComment(skill);
            Console.WriteLine(comment);
        }
        static string GenerateComment(string skill)
        {
            return $"This is a comment about the skill: {skill}";
        }
    }
}