using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using static BlazingPizza.Client.Shared.MainLayout;

namespace BlazingPizza.Client.Pages
{
    public partial class Counter
    {
        [CascadingParameter] public AppState AppState { get; set; }

        [Inject] private SingletionService singletion { get; set; }
        [Inject] private TransientService transient { get; set; }
        [Inject] private IJSRuntime js { get; set; }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [CascadingParameter] private Task<AuthenticationState> AuthenticationState { get; set; }

        [JSInvokable]
        public async Task IncrementCount()
        {
            var authState = await AuthenticationState.ConfigureAwait(false);
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                currentCount++;
                transient.Value = currentCount;
                singletion.Value = currentCount;
                currentCountStatic++;
                await js.InvokeVoidAsync("dotnetStaticInvocation");
            }
            else
            {
                currentCount--;
            }
        }

        private async Task IncrementCountJavaScript()
        {
            //C#(IncrementCountJavaScript) → js(dotnetInstanceInvocation) → C#(IncrementCount)
            await js.InvokeVoidAsync("dotnetInstanceInvocation",
                DotNetObjectReference.Create(this));
        }

        //jsからのメソッドコール
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}