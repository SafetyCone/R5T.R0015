using System;

using Microsoft.AspNetCore.Components;

using R5T.T0142;
using R5T.T0154;


namespace R5T.R0015
{
    /// <summary>
    /// Host type for custom event <see cref="EventHandlerAttribute"/> attributes.
    /// </summary>
    /// <remarks>
    /// For helpful documentation, see the documentation type: <see cref="Y0007.Documentation.For_EventHandlers"/>.
    /// </remarks>
    [EventHandler("ontransitionend", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: false)]
    [EventHandler("onanimationend", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: false)]
    [RazorComponentMarker] // Also put this type in the Razor components list.
    [UtilityTypeMarker]
    public static class EventHandlers
    {
    }
}
