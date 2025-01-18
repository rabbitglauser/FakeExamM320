using System.Collections.Generic;
using System.Linq;

namespace ExamM320
{
    public class TeamCompetition : Competition
    {
        public int MinTeamSize { get; private set; } = 1;
        public int MaxTeamSize { get; private set; }

        public TeamCompetition(string title, int maxTeamSize) : base(title)
        {
            MaxTeamSize = maxTeamSize;
        }

        public TeamCompetition(string title, int maxTeamSize, int minTeamSize) : this(title, maxTeamSize)
        {
            MinTeamSize = minTeamSize;
        }

        public override bool AddContestant(Contestant contestant)
        {
            Team team = contestant as Team;
            if (team != null)
            {
                _contestants.Add(team);
                team.Competition = this;
                return true;
            }

            return false;
        }

        public List<Team> GetInvalidTeams()
        {
            return _contestants.Where(contestant => contestant.GetType() == typeof(Team))
                               .Select(contestant => contestant as Team)
                               .Where(team => !team.IsValidTeamSize)
                               .ToList();
        }
    }
}