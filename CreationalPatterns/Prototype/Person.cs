using System;

namespace CreationalPatterns.Prototype
{
    public class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateCreated { get; set; }

        public Person Clone()
        {
            Person person = (Person)this.MemberwiseClone();
            return person;
        }

        public string ToObjectString()
        {
            return $"DateCreated - {DateCreated}, PersonId - {PersonId}, FirstName - {FirstName}, LastName -{LastName}\n";
        }
    }
}