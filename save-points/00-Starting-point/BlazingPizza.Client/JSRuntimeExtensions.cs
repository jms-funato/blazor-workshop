using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazingPizza.Client
{
    //Javascript相互運用 拡張メソッド
    public static class JSRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("confirm", message);
        }
    }
}