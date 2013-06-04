using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Owin;

namespace KatanaWinSvcSample
{
    public class WebStartup
    {
        /// <summary>
        /// The method name is defined by convention
        /// </summary>
        public void Configuration(IAppBuilder app)
        {
            //Configure the app with the OWIN components to use
            
            //app.UseTestPage();

            string staticFilesDir = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "webdir");

            app.UseStaticFiles(staticFilesDir);

            app.UseWebApi(cfg =>
            {
                cfg.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional });
            });

        }
    }
}
