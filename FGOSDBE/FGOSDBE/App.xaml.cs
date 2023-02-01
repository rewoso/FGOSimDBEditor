using FGOSDBE.Modules.ModuleName;
using FGOSDBE.Services;
using FGOSDBE.Services.Interfaces;
using FGOSDBE.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace FGOSDBE
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IDBEditorService, DBEditorService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
