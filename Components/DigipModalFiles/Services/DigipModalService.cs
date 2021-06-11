
using System;
using EstacionamientoMedido.Components;
using Microsoft.AspNetCore.Components;

namespace EstacionamientoMedido.Components.DigipModalFiles
{
    public class DigipModalService : IDigipModalService
    {

        internal event Action<DigipModalReference> OnModalInstanceAdded;

        /// <summary>
        /// Shows the modal with the component type.
        /// </summary>
        public DigipModalReference Show<T>() where T : ComponentBase
        {
            return Show<T>(string.Empty, new DigipModalParameters(), new DigipModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified title.
        /// </summary>
        /// <param name="title">Modal title.</param>
        public DigipModalReference Show<T>(string title) where T : ComponentBase
        {
            return Show<T>(title, new DigipModalParameters(), new DigipModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified title.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="options">Options to configure the modal.</param>
        public DigipModalReference Show<T>(string title, DigipModalOptions options) where T : ComponentBase
        {
            return Show<T>(title, new DigipModalParameters(), options);
        }

        /// <summary>
        /// Shows the modal with the component type using the specified <paramref name="title"/>, 
        /// passing the specified <paramref name="parameters"/>. 
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        public DigipModalReference Show<T>(string title, DigipModalParameters parameters) where T : ComponentBase
        {
            return Show<T>(title, parameters, new DigipModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified <paramref name="title"/>, 
        /// passing the specified <paramref name="parameters"/> and setting a custom CSS style. 
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        /// <param name="options">Options to configure the modal.</param>
        public DigipModalReference Show<T>(string title, DigipModalParameters parameters, DigipModalOptions options) where T : ComponentBase
        {
            return Show(typeof(T), title, parameters, options);
        }

        /// <summary>
        /// Shows the modal with the specific component type.
        /// </summary>
        /// <param name="contentComponent">Type of component to display.</param>
        public DigipModalReference Show(Type contentComponent)
        {
            return Show(contentComponent, string.Empty, new DigipModalParameters(), new DigipModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified title.
        /// </summary>
        /// <param name="contentComponent">Type of component to display.</param>
        /// <param name="title">Modal title.</param>
        public DigipModalReference Show(Type contentComponent, string title)
        {
            return Show(contentComponent, title, new DigipModalParameters(), new DigipModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified title.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="contentComponent">Type of component to display.</param>
        /// <param name="options">Options to configure the modal.</param>
        public DigipModalReference Show(Type contentComponent, string title, DigipModalOptions options)
        {
            return Show(contentComponent, title, new DigipModalParameters(), options);
        }

        /// <summary>
        /// Shows the modal with the component type using the specified <paramref name="title"/>, 
        /// passing the specified <paramref name="parameters"/>. 
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="contentComponent">Type of component to display.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        public DigipModalReference Show(Type contentComponent, string title, DigipModalParameters parameters)
        {
            return Show(contentComponent, title, parameters, new DigipModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified <paramref name="title"/>, 
        /// passing the specified <paramref name="parameters"/> and setting a custom CSS style. 
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        /// <param name="options">Options to configure the modal.</param>
        public DigipModalReference Show(Type contentComponent, string title, DigipModalParameters parameters, DigipModalOptions options)
        {
            if (!typeof(ComponentBase).IsAssignableFrom(contentComponent))
            {
                throw new ArgumentException($"{contentComponent} must be a Blazor Component");
            }

            Guid modalInstanceId = Guid.NewGuid();

            RenderFragment modalContent = new RenderFragment(builder =>
            {
                int i = 0;
                builder.OpenComponent(i++, contentComponent);
                foreach (var parameter in parameters._parameters)
                {
                    builder.AddAttribute(i++, parameter.Key, parameter.Value);
                }
                builder.CloseComponent();
            });

            RenderFragment modalInstance = new RenderFragment(builder =>
            {
                builder.OpenComponent<DigipModalInstance>(0);
                builder.AddAttribute(1, "ModalOptions", options);
                builder.AddAttribute(2, "Title", title);
                builder.AddAttribute(3, "Content", modalContent);
                builder.AddAttribute(3, "Id", modalInstanceId);
                builder.CloseComponent();
            });
            DigipModalReference modalReference = new DigipModalReference(modalInstanceId, modalInstance);

            OnModalInstanceAdded?.Invoke(modalReference);

            return modalReference;
        }
    }
}
