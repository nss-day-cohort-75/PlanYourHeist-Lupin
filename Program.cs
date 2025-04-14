// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata.Ecma335;

List <Member> team = new List<Member>();

int bankDifficulty = 100;

Console.WriteLine("Plan Your Heist!");

while(true){
Member member = new Member();

Console.WriteLine("Enter a team member's name:");
string name = Console.ReadLine().Trim();
if(string.IsNullOrEmpty(name)) { break; }
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

int teamLVL = team.Sum(member => member.SkillLevel);

if (teamLVL >= bankDifficulty) {
    Console.WriteLine("Heist success!")
} else {
    Console.WriteLine("Heist failed...")
}