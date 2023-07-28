using System;

namespace CreationalPatterns.Prototype
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public string Edition { get; set; }

        public double Price { get; set; }

        public DateTime DateCreated { get; set; }

        public Person Author { get; set; }

        public Book Clone()
        {
            Book cloneBookObjec = (Book)this.MemberwiseClone();

            cloneBookObjec.Author = this.Author.Clone();

            return cloneBookObjec;
        }

        public string ToObjectString()
        {
            return $"DateCreated - {DateCreated}, BookId - {BookId}, BookName - {BookName}, Edition - {Edition}, Price -{Price}\n";
        }
    }
}
