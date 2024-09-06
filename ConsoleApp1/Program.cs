using ConsoleApp1;

Skill attack = new() {

Name = "Attack enemy",
ManaCost = 10
};

Skill heal = new()
{
    Name = "Heal self",
    ManaCost = 20
};

Enemy dino = new();

Skill active = attack;

Console.WriteLine("An enemy has appeared, his name is Dino.");
Console.WriteLine("Type attack to attack the enemy");

while (dino.Health != 0)
{
string attackera = Console.ReadLine();

if (attackera == "attack")
{
    dino.Health -= 20;
    Console.WriteLine($"Enemy health is at {dino.Health}");
}
}

Console.WriteLine("you defeated the enemy congrats!");


Console.WriteLine(active.Name);
Console.ReadLine();

