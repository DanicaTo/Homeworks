using System;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Task1
            
            
            //    int[] arrayOfInt = new int[6];
            //    int result = 0;
            //    for (int i = 0; i <= arrayOfInt.Length; i++)
            //    {
            //        Console.WriteLine("Enter a number:");
            //        string input = Console.ReadLine();
            //        int newResult;
            //        bool parsedResult = int.TryParse(input, out newResult);
            //        if (parsedResult)
            //        {
            //            arrayOfInt[i] = newResult;
            //            if (arrayOfInt[i] % 2 == 0)
            //            {
            //                result += arrayOfInt[i];
            //            }
            //        }
            //    }
            //    Console.ReadLine();
            
            //#endregion

            #region Task2
            string[] studentsG1 = new string[] { "Bob", "Anne", "Mike", "Sam", "June" };
            string[] studentsG2 = new string[] { "James", "Mary", "Eliot", "Megan", "John" };
            Console.WriteLine("Enter students group, 1 or 2:");
            string inputGroup = Console.ReadLine();
            int userName = 0;
            bool parsingNum = int.TryParse(inputGroup, out userName);
            if (parsingNum)
            {
                if (userName == 1)
                {


                    Console.WriteLine("The students in this group are: ");
                    foreach (var n in studentsG1)
                    {

                        Console.WriteLine(n);
                    }

                }
                else
                {
                    if (userName == 2)
                    {
                        Console.WriteLine("The students in this group are: ");
                        foreach (var n in studentsG2)
                        {

                            Console.WriteLine(n);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please enter group 1 or 2");
                    }
                }
                Console.ReadLine();
                #endregion
            }
        }
    }
}
