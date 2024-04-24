using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8080");

            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            // Custom route
            config.Routes.MapHttpRoute(
                name: "IapApi",
                routeTemplate: "iap/alarm-manager/get-all-alarm-ids",
                defaults: new { controller = "IapAlarmManager", action = "GetAllAlarmIds" }
            );

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
