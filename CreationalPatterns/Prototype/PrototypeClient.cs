using System;

namespace CreationalPatterns.Prototype
{
    internal class PrototypeClient
    {
        public static void TestPrototypeClient()
        {
            /* STEP 1 - CREATE THE ORIGINAL OBJECT AND TEST IT STATE*/

            Console.WriteLine("CREATE THE ORIGINAL OBJECT AND TEST IT STATE\n");

            Person originalPerson = new Person()
            {
                FirstName = "Fredrik",
                LastName = "Backman",
                PersonId = 4,
                DateCreated = DateTime.Now
            };

            Book originalBook = new Book()
            {
                BookId = 1,
                BookName = "Becoming",
                Edition = "Kindle",
                Price = 649,
                DateCreated = DateTime.Now,
                Author = originalPerson
            };

            Console.WriteLine(originalBook.ToObjectString());
            Console.WriteLine(originalBook.Author.ToObjectString());

            Console.WriteLine("\n");

            /* STEP 2 - CLONE THE ORIGINAL OBJECT AND TEST IT STATE */

            Console.WriteLine("\nCLONE THE ORIGINAL OBJECT AND TEST IT STATE\n");

            Book cloneBook = originalBook.Clone();

            cloneBook.BookId = 2;
            cloneBook.BookName = "A Thousand Splendid Suns";
            cloneBook.Edition = "Paperback";
            cloneBook.Price = 321;
            cloneBook.DateCreated = DateTime.Now;
            cloneBook.Author.FirstName = "Sheryl";
            cloneBook.Author.LastName = "Sandberg";
            cloneBook.Author.PersonId = 8;
            cloneBook.Author.DateCreated = DateTime.Now;

            Console.WriteLine(cloneBook.ToObjectString());
            Console.WriteLine(cloneBook.Author.ToObjectString());

            Console.WriteLine(originalBook.ToObjectString());
            Console.WriteLine(originalBook.Author.ToObjectString());

            Console.WriteLine("\n");
            /* STEP 3 - COPY THE ORIGINAL OBJECT AND TEST IT STATE */

            Console.WriteLine("\nCOPY THE ORIGINAL OBJECT AND TEST IT STATE\n");

            Book copyBook = originalBook;

            copyBook.BookId = 3;
            copyBook.BookName = "Kudiarasu 1925 Periyarin Ezhuthum Pechum";
            copyBook.Edition = "Kindle";
            copyBook.Price = 99;
            copyBook.DateCreated = DateTime.Now;
            copyBook.Author.FirstName = "Periyar";
            copyBook.Author.LastName = "EVR";
            copyBook.Author.PersonId = 12;
            copyBook.Author.DateCreated = DateTime.Now;

            Console.WriteLine(copyBook.ToObjectString());
            Console.WriteLine(copyBook.Author.ToObjectString());

            Console.WriteLine(originalBook.ToObjectString());
            Console.WriteLine(originalBook.Author.ToObjectString());
        }

        public static void TestMethod()
        {
            TestPrototypeClient();
            Console.ReadKey();
        }
    }
}
