using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using static ADPHI.Client.Shared.MainLayout;

namespace ADPHI.Client.Pages
{
    public partial class Counter
    {
        [CascadingParameter] public AppState AppState { get; set; }

        [Inject] private Microsoft.Extensions.Logging.ILogger<Index> logger { get; set; }
        private bool _ActionFailed;

        [Inject] private SingletionService singletion { get; set; }
        [Inject] private TransientService transient { get; set; }
        [Inject] private IJSRuntime js { get; set; }
        [Inject] private Blazored.LocalStorage.ILocalStorageService oLocalStore { get; set; }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [CascadingParameter] private Task<AuthenticationState> AuthenticationState { get; set; }

        private string SessionValue = "";

        protected override async Task OnInitializedAsync()
        {
            logger.LogDebug("initialize Index");
            SessionValue = await oLocalStore.GetItemAsync<string>("MySessionValue");
        }

        [JSInvokable]
        public async Task IncrementCount()
        {
            var authState = await AuthenticationState.ConfigureAwait(false);
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                try
                {
                    currentCount++;
                    transient.Value = currentCount;
                    singletion.Value = currentCount;
                    currentCountStatic++;
                    await js.InvokeVoidAsync("dotnetStaticInvocation");
                }
                catch (System.Exception ex)
                {
                    _ActionFailed = true;
                    logger.LogError(ex, "fail exexute javascript");
                }
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
