namespace ExamM320
{
    public abstract class Sponsor : Partner
    {
        public int Contribution { get; }

        public Sponsor(string name, int contribution) : base(name)
        {
            Contribution = contribution;
        }
    }
}