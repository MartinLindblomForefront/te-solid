namespace LiskovSubstitution;

public abstract class BadBird
{
	public abstract void Fly();
}

public class BadSwallow : BadBird
{
	public override void Fly()
	{
		Console.WriteLine("I can fly, for I am a Swallow :D");
	}
}

public class BadOstrich : BadBird
{
	public override void Fly()
	{
		throw new Exception("I cannot fly, for I am an Ostrich :(");
	}
}