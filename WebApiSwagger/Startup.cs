﻿using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Swashbuckle.Application;
using WebApiSwagger.App_Start;

[assembly: OwinStartup(typeof(WebApiSwagger.Startup))]
namespace WebApiSwagger
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
            HttpConfiguration config = new HttpConfiguration();
            
            WebApiConfig.Register(config);

            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "WebAPI");
                c.IncludeXmlComments(GetXmlCommentsPath());
                c.ResolveConflictingActions(x => x.First());
            }).EnableSwaggerUi();

            app.UseWebApi(config);
        }

        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\WebApiSwagger.XML",
                    System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}