using DependencyInversion.ServiceLocator;

ServiceLocator.Register<IUserService>(new UserService());
ServiceLocator.Register<IAttachmentService>(new AttachmentService());

new CvService().SaveCv(2);
new CvService().SaveCv(4);
new CvService().SaveCv(99);

Console.ReadLine();