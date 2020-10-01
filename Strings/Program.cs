using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string input;
            bool search;
            string newSentence;

            Console.WriteLine("Enter a word to search for:");
            input = Console.ReadLine();
            search = sentence.ToLower().Contains(input.ToLower());
            Console.WriteLine(search);

            if (search.Equals(true))
            {
                Console.WriteLine(sentence.ToLower().IndexOf(input.ToLower()));
                Console.WriteLine(input.Length);
                newSentence = sentence.ToLower().Replace(input.ToLower(), "").Replace("  ", " ");
                Console.WriteLine(newSentence);
            } else
            {
                Console.WriteLine("This word is not in the sentence.");
            }

        }
    }
}
