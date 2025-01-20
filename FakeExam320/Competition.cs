using System;
using System.Collections.Generic;

namespace ExamM320
{
    public abstract class Competition
    {
        public Contestant Winner { get; private set; }
        protected List<Contestant> _contestants;
        public List<Partner> Partners { get; init; }
        public string Title { get; init; }
        public DateTime Date { get; init; }

        public Competition(string title)
        {
            Title = title;
            _contestants = new List<Contestant>();
            Partners = new List<Partner>();
        }

        // subset
        public bool SetWinner(Contestant contestant)
        {
            if (_contestants.Contains(contestant))
            {
                Winner = contestant;
                return true;
            }

            return false;
        }

        public abstract bool AddContestant(Contestant contestant);

        public void AddPartner(string name, int contribution)
        {
            Partners.Add(
                contribution >= PlatinumSponsor.MinimumContribution
                    ? new PlatinumSponsor(name, contribution)
                    : new GoldSponsor(name, contribution)
            );
        }

        public void AddPartner(string name, EMediaType mediaType)
        {
            Partners.Add(new MediaPartner(name, mediaType));
        }
    }
}