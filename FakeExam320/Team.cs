using System.Collections.Generic;

namespace ExamM320
{
    public class Team : Contestant
    {
        private List<IndividualContestant> _members = new List<IndividualContestant>();


        public TeamCompetition Competition { get; set; }

        public bool IsValidTeamSize => _members.Count >= Competition.MinTeamSize && _members.Count <= Competition.MaxTeamSize;

        public bool AddMember(IndividualContestant newMember)
        {
            _members.Add(newMember);
            return IsValidTeamSize;
        }

        public bool RemoveMember(IndividualContestant member)
        {
            _members.Remove(member);
            return IsValidTeamSize;
        }

    }
}