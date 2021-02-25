using DotVVM.AMP.Extensions;
using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace AmpDemo
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            config.AddDotvvmAmp();
            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureResources(config, applicationPath);
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.AddWithAmp("Default", "", "Views/Default.dothtml",config);
            config.RouteTable.AddWithAmp("ComplexElement", "complexElement", "Views/ComplexElement.dothtml",config);
            config.RouteTable.Add("ComplexPage", "complexPage", "Views/ComplexPage.dothtml");
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
            // register code-only controls and markup controls
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {
            // register custom resources and adjust paths to the built-in resources
            config.Resources.Register("Styles", new StylesheetResource()
            {
                Location = new UrlResourceLocation("./style.css")
            });
            // register custom resources and adjust paths to the built-in resources
            config.Resources.Register("SimpleStyle", new StylesheetResource()
            {
                Location = new UrlResourceLocation("./simpleStyle.css")
            });
        }

		public void ConfigureServices(IDotvvmServiceCollection options)
        {
            
            options.AddDotvvmAmpSupport();
            options.AddDefaultTempStorages("temp");
		}
    }
}
