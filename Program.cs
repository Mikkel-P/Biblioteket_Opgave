using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opretter en liste til at holde på vores bøger
            List<Books> bookList = new List<Books>();

            // Opretter bøger til vores collection(liste)
            Books endsWithUs = new Books();
            Books theSeven = new Books();
            Books silentPatient = new Books();
            Books secondPlace = new Books();
            Books thePromise = new Books();
            Books passageNorth = new Books();
            Books brokenHeart = new Books();

            // Tilføjer de oprettede bøger til vores liste inklusiv attributer
            bookList.Add(endsWithUs);
            endsWithUs.Author = "Colleen Hoover";
            endsWithUs.Genre = "Drama";
            endsWithUs.Name = "Ends with us";
            endsWithUs.NumOfPages = 658;
            endsWithUs.Price = 14.99f;

            bookList.Add(theSeven);
            theSeven.Author = "Taylor Jenkins Reid";
            theSeven.Genre = "Drama";
            theSeven.Name = "The seven";
            theSeven.NumOfPages = 871;
            theSeven.Price = 19.99f;

            bookList.Add(silentPatient);
            silentPatient.Author = "Alex Michaels";
            silentPatient.Genre = "Thriller";
            silentPatient.Name = "Silent patient";
            silentPatient.NumOfPages = 528;
            silentPatient.Price = 14.99f;

            bookList.Add(secondPlace);
            secondPlace.Author = "Rachel Cusk";
            secondPlace.Genre = "Biography";
            secondPlace.Name = "Second place";
            secondPlace.NumOfPages = 489;
            secondPlace.Price = 24.99f;

            bookList.Add(thePromise);
            thePromise.Author = "Damon Galgut";
            thePromise.Genre = "Horror";
            thePromise.Name = "The promise";
            thePromise.NumOfPages = 666;
            thePromise.Price = 9.99f;

            bookList.Add(passageNorth);
            passageNorth.Author = "Anuk Arudpran";
            passageNorth.Genre = "Biography";
            passageNorth.Name = "Passage north";
            passageNorth.NumOfPages = 945;
            passageNorth.Price = 14.99f;

            bookList.Add(brokenHeart);
            brokenHeart.Author = "Stephanie Garber";
            brokenHeart.Genre = "Drama";
            brokenHeart.Name = "Broken heart";
            brokenHeart.NumOfPages = 792;
            brokenHeart.Price = 29.99f;

            // Opretter en stack vi bruger til at holde styr på udlånte bøger
            Stack<Books> borrowedBooks = new Stack<Books>();

            while (true)
            {
                // For each item in the booklist we write out all the items attributes
                // Also adding a counter, so you easily can pick the books you want
                int i = 1;
                foreach (Books item in bookList)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Book name: " + item.Name);
                    Console.WriteLine("Author: " + item.Author);
                    Console.WriteLine("Genre: " + item.Genre);
                    Console.WriteLine("Number of pages: " + item.NumOfPages);
                    Console.WriteLine("Price: " + item.Price + "$");
                    Console.WriteLine();
                    i++;
                }

                // int.Parse catches the user input as a int data type, instead of the string type
                // that the input was originally in, can only handle numbers
                Console.Write("Write the number of the book you want to borrow. Use 0 when done.");
                int userChoice = int.Parse(Console.ReadLine());

                // This enables us to add the books the user chooses to our stack called borrowedBooks
                // Exits with a 0, or a number higher than what is available
                if (userChoice < 1 || userChoice > bookList.Count)
                {
                    // Jump statement that lets the user exit when the books have been picked out
                    goto exit;
                }

                // Copies the users choice from the bookList to the borrowedBooks stack
                // removes it from the bookList as well
                borrowedBooks.Push(bookList[userChoice - 1]);
                bookList.RemoveAt(userChoice - 1);

                if (borrowedBooks.Count < 0) { BookRent(); }
            }

            exit:

            BookRent();

            Console.ReadLine();

            Exit();

            // This method runs through our stack, and writes to the console what the next item is, before removing it
            void BookRent()
            {
                while (borrowedBooks.Count > 0)
                {
                    Console.WriteLine("Renting " + borrowedBooks.Peek().Name + " - " + borrowedBooks.Peek().Author + " was succesful.");
                    borrowedBooks.Pop();
                }
            }

            // Exits our program
            void Exit()
            {
                Environment.Exit(0);
            }
        }
    }
}

