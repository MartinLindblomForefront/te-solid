namespace DependencyInversion.ServiceLocator;

public class ServiceLocator
{
    private static Dictionary<Type, object> registry = new Dictionary<Type, object>();

    public static void Register<T>(T instance)
    {
        registry[typeof(T)] = instance;
    }

    public static T GetService<T>()
    {
        return (T)registry[typeof(T)];
    }
}