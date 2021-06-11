using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace EstacionamientoMedido.Components.DigipModalFiles
{
    public class DigipModalReference
    {
        private readonly TaskCompletionSource<DigipModalResult> _resultCompletion = new TaskCompletionSource<DigipModalResult>();
        private event Action<DigipModalResult> Closed;
        public DigipModalReference(Guid modalInstanceId, RenderFragment modalInstance)
        {
            Id = modalInstanceId;
            ModalInstance = modalInstance;
            Closed += HandleClosed;
        }

        private void HandleClosed(DigipModalResult obj)
        {
            _ = _resultCompletion.TrySetResult(obj);
        }

        internal Guid Id { get; set; }
        internal RenderFragment ModalInstance { get; set; }

        public Task<DigipModalResult> Result => _resultCompletion.Task;

        internal void Dismiss(DigipModalResult result)
        {
            Closed.Invoke(result);
        }
    }
}