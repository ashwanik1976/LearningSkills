using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism;
using Prism.Unity;
using Prism.Modularity;


namespace WpfApp
{
    public class Bootstrapper : UnityBootstrapper
    {
        
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Shell>();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;
            SampleModule.ViewModels.SampleViewModel VM = new SampleModule.ViewModels.SampleViewModel();
            App.Current.MainWindow.DataContext = VM;
            App.Current.MainWindow.Show();
        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            Type sampleModuleType = typeof(SampleModule.SampleModule);
            ModuleCatalog.AddModule(new Prism.Modularity.ModuleInfo { ModuleName = sampleModuleType.Name, ModuleType = sampleModuleType.AssemblyQualifiedName });
        }
    }
}
