// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineDesignServices : ComponentBase
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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M20.97,7.27c0.39-0.39,0.39-1.02,0-1.41l-2.83-2.83c-0.39-0.39-1.02-0.39-1.41,0l-4.49,4.49L8.35,3.63 c-0.78-0.78-2.05-0.78-2.83,0l-1.9,1.9c-0.78,0.78-0.78,2.05,0,2.83l3.89,3.89L3,16.76V21h4.24l4.52-4.52l3.89,3.89 c0.95,0.95,2.23,0.6,2.83,0l1.9-1.9c0.78-0.78,0.78-2.05,0-2.83l-3.89-3.89L20.97,7.27z M5.04,6.94l1.89-1.9c0,0,0,0,0,0 l1.27,1.27L7.02,7.5l1.41,1.41l1.19-1.19l1.2,1.2l-1.9,1.9L5.04,6.94z M16.27,14.38l-1.19,1.19l1.41,1.41l1.19-1.19l1.27,1.27 l-1.9,1.9l-3.89-3.89l1.9-1.9L16.27,14.38z M6.41,19H5v-1.41l9.61-9.61l1.3,1.3l0.11,0.11L6.41,19z M16.02,6.56l1.41-1.41 l1.41,1.41l-1.41,1.41L16.02,6.56z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
