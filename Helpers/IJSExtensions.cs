using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace EstacionamientoMedido.Helpers
{
    public static class IJSExtensions
    {
        public static async Task<object> MensajeOK(this IJSRuntime js)
        {
            return await js.InvokeAsync<object>("MensajeOK");
        }

        public static async Task<object> MensajeAtencion(this IJSRuntime js, string mensaje)
        {
            return await js.InvokeAsync<object>("MensajeAtencion", mensaje);
        }
        public static async Task<bool> MensajeAtencionConfirm(this IJSRuntime js, string mensaje)
        {
            return await js.InvokeAsync<bool>("MensajeAtencionConfirm", mensaje);
        }

        public static async Task<bool> MensajeConfirm(this IJSRuntime js, string titulo, string Mensaje)
        {
            return await js.InvokeAsync<bool>("MensajeConfirm", titulo, Mensaje);
        }
        public static async Task<bool> MesajeYesOrNo(this IJSRuntime js, string titulo, string Mensaje)
        {
            return await js.InvokeAsync<bool>("MensajeYesOrNo", titulo, Mensaje);
        }
        public static async Task<object> GuardarComo(this IJSRuntime js, string nombreArchivo, byte[] archivo)
        {
            return await js.InvokeAsync<object>("saveAsFile", nombreArchivo, Convert.ToBase64String(archivo));
        }
        public static async Task<object> MensajeToast(this IJSRuntime js, string message)
        {
            return await js.InvokeAsync<object>("MensajeToast", message);
        }   
    }
}