namespace _25._04Pratice.Models
{
    internal class Coordinator : Person
    {
        public Coordinator(string Work) : base()
        {
            this.Work = Work;
        }

        public string Work { get; set; }
        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }
}
