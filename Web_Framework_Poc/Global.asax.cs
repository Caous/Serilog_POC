
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using SerilogBase.Infraestructure.Interface;
using SerilogBase.Infraestructure.Service;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Web_Framework_Poc.Service;

namespace Web_Framework_Poc
{
    public class Global : HttpApplication
    {
   
        void Application_Start(object sender, EventArgs e)
        {
            RegisterContainer();
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
       

        }

        private void RegisterContainer()
        {
            var container = this.AddUnity();
            container.RegisterType<ILogBase, LogBaseService>();
        }
    }
}