using System.Text.RegularExpressions;

namespace _25._04Pratice.Models
{
    abstract class Person
    {
        public Person()
        {

        }
        public Person(string Name, string Surname, int Age)
        {

            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public static int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public abstract void Speak();
 
    }
}
