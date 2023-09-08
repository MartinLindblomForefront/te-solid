namespace InterfaceSegregation;

public class Hp001
{
	public void Print()
	{

	}
}

public class Hp002
{
	public void Print()
	{

	}

	public void Scan()
	{

	}
}

public class HpMega
{
	public void Print()
	{

	}

	public void Scan()
	{

	}

	public void Copy()
	{

	}

	public void Fax()
	{

	}
}

public class HpMega2 : IBadPrinter
{

}