using System;

namespace CharCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write something!");
            string input = Console.ReadLine().ToLower();
            Counter(input);
        }

        static void Counter(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int LetterCount = 1;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        LetterCount++;
                    }
                }

                if (i == input.IndexOf(input[i]))
                {
                    Console.Write(input[i] + " : " + LetterCount + "|| ");
                }
            }
            Console.ReadLine();
        }
    }
}