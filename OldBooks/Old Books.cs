using System;

namespace _01Old_Books
{
    internal class OldBooks
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int counter = 0;
            bool isFound = false;
            string nextBookName = Console.ReadLine();

            while (nextBookName != "No More Books")
            {
                if (nextBookName == favoriteBook)
                {
                    isFound = true;
                    break;
                }
                nextBookName = Console.ReadLine();
                counter++;

            }
            if (isFound == true)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!\n You checked {counter} books.");
            }
        }
    }
}
