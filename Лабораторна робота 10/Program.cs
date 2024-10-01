using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string of words separated by spaces:");
        string inputString = Console.ReadLine();

        int numberOfWords = CountWordsStartingWithVowel(inputString);

        Console.WriteLine("Number of words starting with a vowel: " + numberOfWords);
    }

    static int CountWordsStartingWithVowel(string inputString)
    {
        string[] words = inputString.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            char firstLetter = word[0];
            if (IsVowel(firstLetter))
            {
                count++;
            }
        }

        return count;
    }

    static bool IsVowel(char letter)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
        return Array.Exists(vowels, v => v == letter);
    }
}
