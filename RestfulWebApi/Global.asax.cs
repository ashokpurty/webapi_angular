using BusinessService;
using Microsoft.Practices.Unity;
using RestfulWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RestfulWebApi
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Create a new Unity dependency injection container
            var unity = new UnityContainer();

            // Register the Controllers that should be injectable
            unity.RegisterType<CalculatorController>();

            // Register instances to be used when resolving constructor parameter dependencies
            unity.RegisterInstance(new Calculator());

            // Finally, override the default dependency resolver with Unity
            GlobalConfiguration.Configuration.DependencyResolver = new IoCContainer(unity); ;
        }
    }
}