namespace ExamM320
{
    public class IndividualCompetition : Competition
    {
        private int _minContestantAge;

        public IndividualCompetition(string title) : base(title) { }

        public IndividualCompetition(string title, int minContestantAge) : base(title)
        {
            _minContestantAge = minContestantAge;
        }

        public override bool AddContestant(Contestant contestant)
        {
            if (contestant.GetType() == typeof(IndividualContestant))
            {
                _contestants.Add(contestant);
                return true;
            }

            return false;
        }
    }
}