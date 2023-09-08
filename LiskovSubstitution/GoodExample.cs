namespace LiskovSubstitution;

public abstract class Bird
{
	public abstract void LayEgg();
}

public abstract class FlyingBird : Bird
{
	public abstract void Fly();
}

public class Swallow : FlyingBird
{
	public override void Fly()
	{
		Console.WriteLine("I can fly, for I am a Swallow :D");
	}

	public override void LayEgg()
	{
		Console.WriteLine("I can lay eggs, for I am a Swallow :D");
	}
}

public class Ostrich : Bird
{
	public override void LayEgg()
	{
		Console.WriteLine("I can lay eggs, for I am an Ostrich :D");
	}
}