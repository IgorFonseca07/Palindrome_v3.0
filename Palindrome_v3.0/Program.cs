using System;

namespace Palindrome_v3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Developed by Igor Oliveira Fonseca

            Console.Write("What's the sequence of characters (can be a word, number, phrase...): ");
            string[] input = Console.ReadLine().ToUpper().Trim().Split(' ');
            string sequenceCharacters = "";

            for (int i = 0; i < input.Length; i++)
            {
                sequenceCharacters += input[i];
            }

            int count = 0;
            for (int i = 0; i < (sequenceCharacters.Length / 2); i++)
            {
                if (sequenceCharacters[i] == sequenceCharacters[sequenceCharacters.Length - (i + 1)])
                {
                    count++;
                }
            }
            Console.WriteLine();

            Console.Write("Backward: ");
            for (int i = (sequenceCharacters.Length - 1); i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(sequenceCharacters[i]);
                }
                else
                {
                    Console.Write(sequenceCharacters[i]);
                }
            }
            Console.WriteLine("Forward:  " + sequenceCharacters);
            Console.WriteLine();

            if (count == (sequenceCharacters.Length / 2))
            {
                Console.WriteLine("It's Palindrome!");
            }
            else
            {
                Console.WriteLine("It's not Palindrome!");
            }
        }
    }
}
