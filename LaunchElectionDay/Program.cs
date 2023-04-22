using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");
var JaredPolis = new Candidate("Jared Polis", "Democrat");

Console.WriteLine(diana.Name);
Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);

Race race1 = new Race("Mayoral Race");
race1.RegisterCandidate(diana);
race1.RegisterCandidate(JaredPolis);

Election election1 = new Election("3043");
election1.AddRace(race1);

//List<Candidate> allCanidatesInRace = election1.GetCandidatesRace(race1);
//foreach(var c in allCanidates)
//{
//    Console.WriteLine(c.Name);
//}

//var canidateVotes = election1.GetVoteCountsRace(race1);

//foreach(var c in canidateVotes)
//{
//    Console.WriteLine($"{c.Key} has {c.Value} votes");
//}

List<Candidate> allCanidates = election1.GetAllCandidates();
foreach(var c in allCanidates)
{
    Console.WriteLine(c.Name);
}

var allCanidatesVotes = election1.GetAllVoteCounts();
foreach (KeyValuePair<string,int> c in allCanidatesVotes)
{
    Console.WriteLine($"{c.Key} has {c.Value} votes");

}

string winner = GetWinner();
