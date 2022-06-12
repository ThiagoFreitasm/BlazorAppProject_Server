using Microsoft.JSInterop;

namespace BlazorApp_Server.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime _jsRuntime, string message)
        {
            await _jsRuntime.InvokeVoidAsync("ShowToastr", "succes", message);
        }
        public static async ValueTask ToastrError(this IJSRuntime _jsRuntime, string message)
        {
            await _jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}
