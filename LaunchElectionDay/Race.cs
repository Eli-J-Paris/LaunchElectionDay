using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Race
    {

        public string Office;
        public List<Candidate> Candidates;
        public bool IsOpen;

        public Race(string office)
        {
            Office = office;
            Candidates = new List<Candidate>();
           
        }

        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }
        
        public void OpenRace(bool open)
        {
            if(open == true) 
            IsOpen = true;
            else
            IsOpen = false;  
        }

        public void CloseRace()
        {
            IsOpen = false;
        }

        public string GetWinner()
        {
            string winner = "";
            foreach(var c in Candidates)
            {
                if(c.Votes < 0)
                {
                    winner = c;
                }
            }
            return winner;
        }

    }
}
