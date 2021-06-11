using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace EstacionamientoMedido.Components.DigipModalFiles
{
    public static class DigipModalIJSExtensions
    {
        public static async Task<object> ScrollLock(this IJSRuntime js)
        {
            return await js.InvokeAsync<object>("ScrollLock");
        }
        public static async Task<object> ScrollUnlock(this IJSRuntime js)
        {
            return await js.InvokeAsync<object>("ScrollUnlock");
        }
    }
}
