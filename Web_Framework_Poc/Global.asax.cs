using SerilogBase.Infraestructure.Interface;
using SerilogBase.Infraestructure.Service;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

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
            var container = new Container();

            container.Register<ILogBase, LogBaseService>(Lifestyle.Singleton);

            container.Verify();

            DependencyResolver.SetResolver(
                new SimpleInjectorDependencyResolver(container));

        }
    }
}