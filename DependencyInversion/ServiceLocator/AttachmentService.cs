namespace DependencyInversion.ServiceLocator;

public interface IAttachmentService
{
	public void SaveAttachment(string name);
}

public class AttachmentService : IAttachmentService
{
	public void SaveAttachment(string name)
	{
		Console.WriteLine($"Saving attachment: {name}");
	}
}