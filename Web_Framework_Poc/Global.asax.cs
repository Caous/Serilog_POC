﻿using SerilogBase.Infraestructure.Interface;
using SerilogBase.Infraestructure.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Ninject.IKernel inject = new StandardKernel();
            //inject.Bind<ILogBase>().To<LogBaseService>();


        }
    }
}