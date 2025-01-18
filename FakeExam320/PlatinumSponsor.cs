namespace ExamM320
{
    public class PlatinumSponsor : Sponsor
    {
        public const int MinimumContribution = 25000;

        public PlatinumSponsor(string name, int contribution) : base(name, contribution) { }
    }
}