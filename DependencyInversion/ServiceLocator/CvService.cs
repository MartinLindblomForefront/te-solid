namespace DependencyInversion.ServiceLocator;

public class CvService
{
	public void SaveCv(int userId)
	{
		var userService = ServiceLocator.GetService<IUserService>();
		var cv = userService.GetCv(userId);

		var attachmentsService = ServiceLocator.GetService<IAttachmentService>();
		attachmentsService.SaveAttachment(cv);
	}
}