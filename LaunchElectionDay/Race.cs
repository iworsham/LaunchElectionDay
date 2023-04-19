using System;
namespace LaunchElectionDay
{
    public class Race
    {
        public string Office;
        public List<Candidate> Candidates;

        public Race(string office)
        {
            Office = office;
            Candidates = new List<Candidate> { };
        }

        public void RegisterCandidate(Candidate candidateToAdd)
        {
            Candidates.Add(candidateToAdd);
        }
    }
}
