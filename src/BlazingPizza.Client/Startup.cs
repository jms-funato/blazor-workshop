using BlazingPizza.Client.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingPizza.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<OrderState>();

            // Add auth services
            services.AddAuthorizationCore();
            services.AddScoped<JWTAuthenticationProvider>();
            services.AddScoped<AuthenticationStateProvider, JWTAuthenticationProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationProvider>());
            services.AddScoped<ILoginService, JWTAuthenticationProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationProvider>());


            //services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
            //services.AddScoped<AuthenticationStateProvider, DummyAuthStateProvider>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
