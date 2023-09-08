namespace InterfaceSegregation;

public interface IPrinter
{
	void Print();
}

public interface IScan
{
	void Scan();
}

public interface ICopy : IScan
{
	void Copy();
}

public interface IFax : IScan
{
	void Fax();
}

public interface IStaple : IPrinter
{
	void Staple();
}