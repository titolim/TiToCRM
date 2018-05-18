using Autofac;
using TiToCRM.UI.Data;
using TiToCRM.UI.ViewModel;

namespace TiToCRM.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<ContactDataService>().As<IContactDataService>();

            return builder.Build();
        }
    }
}