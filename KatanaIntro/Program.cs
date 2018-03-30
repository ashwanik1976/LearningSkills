using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaIntro
{
    using appFunc = Func<IDictionary<string, Object>, Task>;
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8080";
            using (WebApp.Start<Startup>(uri))
            {
                Console.Write("Started!");
                Console.ReadKey();
                Console.Write("Stoping!");
            }
        }
    }
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage();

            //app.Run(context =>
            //{
            //    //context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync("Hell Ashwani Kumar");
            //});
            //app.Run(context =>
            //{
            //    context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync("Hello, world.");
            //});
            // app.Use<HelloWorldComponnt>();

            //app.Use(async (environment))
        }
    }
    public class HelloWorldComponnt
    {
        appFunc _next;
        public HelloWorldComponnt(appFunc next)
        {
            _next = next;
        }
        public async Task Invoke(IDictionary<string,object> environment)
        {
            await _next(environment);
        }
    }
}
