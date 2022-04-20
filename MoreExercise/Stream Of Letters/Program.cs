using System;

namespace _0003._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string l = Console.ReadLine();
            
            bool O = false;
            bool N = false;
            bool C = false;
            string word = string.Empty;
            
            while (l != "End")
            {
                char letter = char.Parse(l);

                if (char.IsLetter(letter))
                {
                    if (letter == 'c' && !C)
                    {
                        C = true;
                    }
                    else if (letter == 'o' && !O)
                    {
                        O = true;
                    }
                    else if (letter == 'n' && !N)
                    {
                        N = true;
                    }
                    else
                    {
                        word += letter;
                    }
                    if (N == true && C == true && O == true)
                    {
                        
                        Console.Write(word + " ");
                       
                        word = string.Empty;
                        O = false;
                        C = false;
                        N = false;
                    }
                }
                l = Console.ReadLine();
            }
            
        }
    }
}
