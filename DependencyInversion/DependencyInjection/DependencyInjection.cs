using DependencyInversion.ServiceLocator;

namespace DependencyInversion.DependencyInjection;

public class DependencyInjection
{
	// ¯\_(ツ)_/¯
}

public class DependencyInjectionExample
{
	private readonly IUserService _userService;
	private readonly IAttachmentService _attachmentService;

	public DependencyInjectionExample(IUserService userService, IAttachmentService attachmentService)
	{
		_userService = userService;
		_attachmentService = attachmentService;
	}

	public void SaveCv(int userId)
	{
		var cv = _userService.GetCv(userId);
		_attachmentService.SaveAttachment(cv);
	}
}