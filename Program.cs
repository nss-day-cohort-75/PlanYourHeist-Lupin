// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Plan Your Heist!");

Member member = new Member();

Console.WriteLine("Enter a team member's name:");
member.Name = Console.ReadLine();

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
