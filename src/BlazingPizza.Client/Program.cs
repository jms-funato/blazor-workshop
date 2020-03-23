using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingPizza.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();




        //core3.2
        //public static async Task Main(string[] args)
        //{
        //    var builder = WebAssemblyHostBuilderContext
        //}


        private static void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<SingletionService>();
        }
    }


}