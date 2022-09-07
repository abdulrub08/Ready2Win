using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Cors;

[assembly: OwinStartup(typeof(ReadyToWin.API.Startup))]

namespace ReadyToWin.API
{
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            UnityConfig.RegisterComponents(config);
            app.UseWebApi(config);
            ////enable cors 
            app.UseCors(CorsOptions.AllowAll);
        }  
    }
}
