using System;

namespace _066._The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wordPawerfull = string.Empty;
            int points = 0;
            while (word != "End of words")
            {
                int sum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];
                    sum += letter;
                }
                
                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y' || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y')
                {
                    sum *= word.Length;
                }
                else
                {
                    sum /= word.Length;
                }
                
                if (sum > points)
                {
                    points = sum;
                    wordPawerfull = word;
                }
                word = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {wordPawerfull} - {points}");
        }
    }
}
