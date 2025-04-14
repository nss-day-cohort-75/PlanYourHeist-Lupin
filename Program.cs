// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

List<Member> team = new List<Member>();

int bankDifficulty = 100;
Random random = new Random();
int luckValue = random.Next(-10, 11);

Console.WriteLine("Plan Your Heist!");
Console.WriteLine("Enter the bank difficulty level");
bankDifficulty = int.Parse(Console.ReadLine().Trim());

while (true)
{
    Member member = new Member();

    Console.WriteLine("Enter a team member's name:");
    string name = Console.ReadLine().Trim();
    if (string.IsNullOrEmpty(name)) { break; }
    member.Name = name;

    Console.WriteLine("Please enter a Skill level:");
    member.SkillLevel = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter a Courage Factor:");
    decimal courage = decimal.Parse(Console.ReadLine());
    while (courage > 2 || courage < 0)
    {
        Console.WriteLine(" Please enter a number between 0.0 - 2.0");
        courage = decimal.Parse(Console.ReadLine());
    }
    member.CourageFactor = courage;


    Console.WriteLine($"The team member's Name is {member.Name}. Their skill level is {member.SkillLevel}. Their courage factor is {member.CourageFactor}.");
    team.Add(member);

}

    Console.WriteLine("Enter the number of trial runs");
    int trials = int.Parse(Console.ReadLine().Trim());

    for (int i = 0; i < team.Count(); i++) {
        if ((team[i].SkillLevel * team[i].CourageFactor) < bankDifficulty) {

            Console.WriteLine($"{team[i].Name} chickened out");

            team.Remove(team[i]);
        }
    }

    int teamLVL = team.Sum(member => member.SkillLevel);
    Console.WriteLine($"Team's combined Skill level:{teamLVL}");
    Console.WriteLine($"Bank's difficulty level: {bankDifficulty}");

    int success = 0;
    int failure = 0;

while(trials > 0){

    luckValue = random.Next(-10, 11);

    if (teamLVL >= bankDifficulty + luckValue)
    {
        Console.WriteLine("Heist success!");
        success++;
    }
    else
    {
        Console.WriteLine("Heist failed...");
        failure++;
    }

    trials--;

}
Console.WriteLine(@$"
Trial runs complete!
Successes: {success}
Failures: {failure}");

