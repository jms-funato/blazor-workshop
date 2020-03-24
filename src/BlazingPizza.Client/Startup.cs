using BlazingPizza.Client.Auth;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
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

            services.AddSingleton<SingletionService>();
            services.AddTransient<TransientService>();

            // Add auth services
            services.AddAuthorizationCore();
            services.AddScoped<JWTAuthenticationProvider>();
            services.AddScoped<AuthenticationStateProvider, JWTAuthenticationProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationProvider>());
            services.AddScoped<ILoginService, JWTAuthenticationProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationProvider>());

            //services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
            //services.AddScoped<AuthenticationStateProvider, DummyAuthStateProvider>();

            //Blazorise
            services.AddBlazorise(options =>
            {
                options.ChangeTextOnKeyPress = true;
            })
               .AddBootstrapProviders()
               .AddFontAwesomeIcons();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}