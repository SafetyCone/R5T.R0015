using System;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using R5T.T0154;


namespace R5T.R0015.Construction.Client.Buttons
{
    /// <summary>
    /// Base class for buttons, providing functional parameters other than styling.
    /// </summary>
    /// <remarks>
    /// See also: R5T.R0006.Buttons.
    /// </remarks>
    [RazorComponentMarker]
    public abstract class ButtonBase : ComponentBase
    {
        /// <summary>
        /// Sets whether the button is disabled or not.
        /// </summary>
        [Parameter]
        public bool Disabled { get; set; }

        /// <summary>
        /// The on-click handler for the button.
        /// </summary>
        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        /// <summary>
        /// The content of the button.
        /// (This is usually just some text.)
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
