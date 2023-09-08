using LiskovSubstitution;

var badBirds = new List<BadBird>
{
	new BadSwallow(),
	new BadOstrich()
};

foreach (var bird in badBirds)
{
	bird.Fly();
}



#region GOOD
var birds = new List<Bird>
{
	new Swallow(),
	new Ostrich()
};

Console.WriteLine("\nBirds");
foreach (var bird in birds)
{
	bird.LayEgg();
}

var flyingBirds = new List<FlyingBird>
{
	new Swallow(),
};

Console.WriteLine("\nFlying Birds");
foreach (var flyingBird in flyingBirds)
{
	flyingBird.LayEgg();
	flyingBird.Fly();
}
#endregion



Console.ReadLine();