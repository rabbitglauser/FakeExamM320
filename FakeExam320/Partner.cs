namespace ExamM320
{
    public abstract class Partner
    {
        public string Name { get; }

        public ContactPerson ContactPerson { get; set; }

        public Partner(string name)
        {
            Name = name;
        }
    }
}