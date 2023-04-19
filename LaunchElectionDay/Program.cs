using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");

Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);

var race = new Race("City Council District 10");

Console.WriteLine(race.Office);


foreach (var person in race.Candidates)
{
    Console.WriteLine(person.Name);
}

race.RegisterCandidate(diana);

foreach (var person in race.Candidates)
{
    Console.WriteLine(person.Name);
}








