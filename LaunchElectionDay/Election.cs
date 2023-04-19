using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Election
    {
        public string Year;
        public List<Race> Races;
        public Election(string year)
        {
            Year = year;
            Races = new List<Race>();
        }

        public string GetYear()
        {
            return Year;
        }

        public List<Race> GetRaces()
        {
            return Races;
        }

        public void AddRace(Race race)
        {
            Races.Add(race);
        }

        public List<Candidate> GetCandidatesRace(Race race)
        {
            List<Candidate> candidates = new List<Candidate>();

            foreach(var canidate in race.Candidates)
            {
                candidates.Add(canidate);
            }

            return candidates;
        }

        public Dictionary<string,int> GetVoteCountsRace(Race race)
        {
            var CandidateVotes = new Dictionary<string, int>();

            foreach(var canidate in race.Candidates)
            {
                CandidateVotes.Add(canidate.Name,canidate.Votes);
            }
            return CandidateVotes;
        }

        public List<Candidate> GetAllCandidates()
        {
            List<Candidate> candidates = new List<Candidate>();

            foreach (Race race in Races)
            {
                foreach(Candidate candidate in race.Candidates)
                {
                    candidates.Add(candidate);
                }
            }

            return candidates;
        }

        public Dictionary<string, int> GetAllVoteCounts()
        {
            var CandidateVotes = new Dictionary<string, int>();

            foreach (Race race in Races)
            {
                foreach(Candidate canidate in race.Candidates)
                CandidateVotes.Add(canidate.Name, canidate.Votes);

            }
            return CandidateVotes;
        }

    }
}
