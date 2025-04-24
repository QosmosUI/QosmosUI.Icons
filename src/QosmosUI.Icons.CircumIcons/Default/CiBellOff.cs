// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiBellOff : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Bell_Off");
		builder.AddAttribute(15, "data-name", "Bell Off");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M9.624,5.2c-.571.3-.079,1.124.5.864.509-.227,1.068-.287,1.115-.95.028-.41.014-.81.476-.993a.776.776,0,0,1,1.035.71c.048.461.035.821.548,1.024a4.811,4.811,0,0,1,2.812,2.432,5.63,5.63,0,0,1,.414,2.467v2.02a.5.5,0,0,0,1,0c0-1.646.185-3.394-.521-4.929a5.542,5.542,0,0,0-3.019-2.808c-.034-.013-.155-.069-.227-.092,0-.021,0-.044,0-.059a2.009,2.009,0,0,0-.257-.945,1.739,1.739,0,0,0-3.1.172,1.992,1.992,0,0,0-.153.792c0,.012,0,.033,0,.052C10.24,4.959,9.808,5.107,9.624,5.2Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M4.57,3.86c-.46-.46-1.17.25-.71.7C4.92,5.62,5.98,6.69,7.04,7.75a5.535,5.535,0,0,0-.57,2.44v4.54a2.122,2.122,0,0,0-1.88,2.11v.53a2.121,2.121,0,0,0,2.12,2.12H10.3a1.725,1.725,0,0,0,3.4,0h3.59a2.12,2.12,0,0,0,1.15-.34l.99.99a.5.5,0,0,0,.71-.71ZM17.7,18.41a1.15,1.15,0,0,1-.41.08H6.71a1.118,1.118,0,0,1-1.12-1.12v-.53a1.118,1.118,0,0,1,1.12-1.12.762.762,0,0,0,.76-.77V10.19A4.375,4.375,0,0,1,7.8,8.51Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
