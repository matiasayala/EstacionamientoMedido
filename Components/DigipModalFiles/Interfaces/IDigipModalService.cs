using System;
using Microsoft.AspNetCore.Components;

namespace EstacionamientoMedido.Components.DigipModalFiles
{
    public interface IDigipModalService
    {
        /// <summary>
        /// Shows a modal containing the specified <typeparamref name="TComponent"/>.
        /// </summary>
        DigipModalReference Show<TComponent>() where TComponent : ComponentBase;

        /// <summary>
        /// Shows a modal containing a <typeparamref name="TComponent"/> with the specified <paramref name="title"/> .
        /// </summary>
        /// <param name="title">Modal title</param>
        DigipModalReference Show<TComponent>(string title) where TComponent : ComponentBase;

        /// <summary>
        /// Shows a modal containing a <typeparamref name="TComponent"/> with the specified <paramref name="title"/> and <paramref name="options"/>.
        /// </summary>
        /// <param name="title">Modal title</param>
        /// <param name="options">Options to configure the modal</param>
        DigipModalReference Show<TComponent>(string title, DigipModalOptions options) where TComponent : ComponentBase;

        /// <summary>
        /// Shows a modal containing a <typeparamref name="TComponent"/> with the specified <paramref name="title"/> and <paramref name="parameters"/>. 
        /// </summary>
        /// <param name="title">Modal title</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed</param>
        DigipModalReference Show<TComponent>(string title, DigipModalParameters parameters) where TComponent : ComponentBase;

        /// <summary>
        /// Shows a modal containing a <typeparamref name="TComponent"/> with the specified <paramref name="title"/>, 
        /// <paramref name="parameters"/> and <paramref name="options"/>.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        /// <param name="options">Options to configure the modal.</param>
        DigipModalReference Show<TComponent>(string title, DigipModalParameters parameters = null, DigipModalOptions options = null) where TComponent : ComponentBase;

        /// <summary>
        /// Shows a modal containing a <paramref name="component"/>.
        /// </summary>
        /// <param name="component">Type of component to display.</param>
        DigipModalReference Show(Type component);

        /// <summary>
        /// Shows a modal containing a <paramref name="component"/> with the specified <paramref name="title"/>.
        /// </summary>
        /// <param name="component">Type of component to display.</param>
        /// <param name="title">Modal title.</param>
        DigipModalReference Show(Type component, string title);

        /// <summary>
        /// Shows a modal containing a <paramref name="component"/> with the specified <paramref name="title"/> and <paramref name="options"/>.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="component">Type of component to display.</param>
        /// <param name="options">Options to configure the modal.</param>
        DigipModalReference Show(Type component, string title, DigipModalOptions options);

        /// <summary>
        /// Shows a modal containing a <paramref name="component"/> with the specified <paramref name="title"/> and <paramref name="parameters"/>.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="component">Type of component to display.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        DigipModalReference Show(Type component, string title, DigipModalParameters parameters);

        /// <summary>
        /// Shows a modal containing a <paramref name="component"/> with the specified <paramref name="title"/>, <paramref name="parameters"/> 
        /// and <paramref name="options"/>.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        /// <param name="options">Options to configure the modal.</param>
        DigipModalReference Show(Type component, string title, DigipModalParameters parameters, DigipModalOptions options);
    }
}
