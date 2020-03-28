using System;

namespace Homework_class04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            string hello = "Hello from SEDC Codecademy v7.0";
            int lengthOfHello = hello.Length;
            Console.WriteLine($"Please enter a number between 1 and {lengthOfHello}");
            string input = Console.ReadLine();
            int n = 0;
            bool parsingSuc = int.TryParse(input, out n);
            if (parsingSuc)
            {
                if (!(n > 1 && n < hello.Length))
                {
                    Console.WriteLine($"Enter a number between 1 and {lengthOfHello} ");
                }
                else
                {
                    string substring = hello.Substring(0, n);

                    Console.WriteLine(substring);
                    Console.WriteLine(lengthOfHello);
                }
            }
                Console.ReadLine();
            #endregion

            #region Task 2
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Enter some character:");
            string character = Console.ReadLine();
            char karak = '0';
            bool parsingKarak = char.TryParse(character, out karak);
            int k = sentence.Length;
            char[] sentenceCharacters = sentence.ToCharArray();
            int count = 0;
            if (parsingKarak)
            {
                foreach (char c in sentenceCharacters)
                {
                    if (c == karak)
                    {
                        count++;
                    }
                }
            }
                Console.WriteLine($"The character that you entered appears: {count} times.");
                Console.ReadLine();
                #endregion
            }
    }
    }

