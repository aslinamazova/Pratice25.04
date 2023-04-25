namespace _25._04Pratice.Models
{
    internal class Student : Person
    {
        public string Group { get; set; }
        public override void Speak()
        {
            Console.WriteLine("Student speak");
        }
        public Student(string Group, int Age,string Name,string Surname): base( Name,  Surname,  Age)
        {
                this.Group = Group;
        }
    }
}
