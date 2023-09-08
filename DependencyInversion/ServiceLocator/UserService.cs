namespace DependencyInversion.ServiceLocator;


public interface IUserService
{
	public string GetCv(int id);
}

public class UserService : IUserService
{
    public string GetCv(int id)
    {
        Console.WriteLine($"Getting user: {id}");

        return $"User {id} CV.pdf";
    }
}   