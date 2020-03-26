using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazingPizza.Client.Helpers
{
    public static class IJSRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("confirm", message);
        }

        public static ValueTask SaveAs(this IJSRuntime js, string filename, byte[] content)
        {
            return js.InvokeVoidAsync("saveAsFile", filename, Convert.ToBase64String(content));
        }

        public static ValueTask DisplayMessage(this IJSRuntime js, string message)
        {
            return js.InvokeVoidAsync("Swal.fire", message);
        }

        public static ValueTask DisplayMessage(this IJSRuntime js, string title, string message, SweetAlertMessageType sweetAlertMessageType)
        {
            return js.InvokeVoidAsync("Swal.fire", title, message, sweetAlertMessageType.ToString());
        }

        public static ValueTask<bool> Confirm(this IJSRuntime js, string title, string message, SweetAlertMessageType sweetAlertMessageType)
        {
            return js.InvokeAsync<bool>("CustomConfirm", title, message, sweetAlertMessageType.ToString());
        }


        public static ValueTask SetInLocalStorage(this IJSRuntime js, string key, string content)
            => js.InvokeVoidAsync(
            "localStorage.setItem",
            key, content
            );

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key)
            => js.InvokeAsync<string>(
                "localStorage.getItem",
                key
                );

        public static ValueTask RemoveItem(this IJSRuntime js, string key)
            => js.InvokeVoidAsync(
                "localStorage.removeItem",
                key);

        //public static ValueTask TableSetting(this IJSRuntime js)
        //{
        //    return js.InvokeVoidAsync("addTableScroll");
        //}

    }

    public enum SweetAlertMessageType
    {
        question, warning, error, success, info
    }


}
