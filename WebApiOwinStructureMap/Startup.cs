using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using WebApiOwinStructureMap.App_Start;
using StructureMap;
using WebApiOwinStructureMap.DependencyResolution;
using System.Diagnostics;

[assembly: OwinStartup(typeof(WebApiOwinStructureMap.Startup))]

namespace WebApiOwinStructureMap
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            IContainer container = IoC.Initialize();
            container.AssertConfigurationIsValid();
            Debug.WriteLine(container.WhatDoIHave());
            HttpConfiguration httpConfiguration = new HttpConfiguration();
            httpConfiguration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
            WebApiConfig.Register(httpConfiguration);
            appBuilder.UseWebApi(httpConfiguration);

        }
    }
}
