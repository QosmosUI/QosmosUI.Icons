// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneMicrowave : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M4,18h10V6H4V18z M7.75,8c0.8,0,1.39,0.39,1.81,0.67C9.87,8.88,10.07,9,10.25,9c0.37,0,0.8-0.41,0.95-0.61 l1.42,1.42c-0.36,0.4-1.22,1.19-2.37,1.19c-0.79,0-1.37-0.38-1.79-0.66C8.13,10.12,7.94,10,7.75,10c-0.37,0-0.8,0.41-0.95,0.61 L5.37,9.19C5.73,8.79,6.59,8,7.75,8z M7.75,13c0.8,0,1.39,0.39,1.81,0.67C9.87,13.88,10.07,14,10.25,14c0.37,0,0.8-0.41,0.95-0.61 l1.42,1.42c-0.36,0.4-1.22,1.19-2.37,1.19c-0.79,0-1.37-0.38-1.79-0.66C8.13,15.12,7.94,15,7.75,15c-0.37,0-0.8,0.41-0.95,0.61 l-1.42-1.42C5.73,13.79,6.59,13,7.75,13z M16,6v12h4V6H16z M18,17c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1c0.55,0,1,0.45,1,1 C19,16.55,18.55,17,18,17z M18,13c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1c0.55,0,1,0.45,1,1C19,12.55,18.55,13,18,13z M19,9h-2V7h2V9 z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M20,4H4C2.9,4,2,4.9,2,6v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6C22,4.9,21.1,4,20,4z M4,6h10v12H4V6z M20,18h-4V6h4V18z M19,9h-2V7h2V9z M18,13L18,13c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h0c0.55,0,1,0.45,1,1v0C19,12.55,18.55,13,18,13z M18,17 L18,17c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h0c0.55,0,1,0.45,1,1v0C19,16.55,18.55,17,18,17z M10.25,16 c-0.79,0-1.37-0.38-1.79-0.66C8.13,15.12,7.94,15,7.75,15c-0.37,0-0.8,0.41-0.95,0.61l-1.42-1.42C5.73,13.79,6.59,13,7.75,13 c0.8,0,1.39,0.39,1.81,0.67C9.87,13.88,10.07,14,10.25,14c0.37,0,0.8-0.41,0.95-0.61l1.42,1.42C12.26,15.21,11.41,16,10.25,16z M10.25,11c-0.79,0-1.37-0.38-1.79-0.66C8.13,10.12,7.94,10,7.75,10c-0.37,0-0.8,0.41-0.95,0.61L5.37,9.19C5.73,8.79,6.59,8,7.75,8 c0.8,0,1.39,0.39,1.81,0.67C9.87,8.88,10.07,9,10.25,9c0.37,0,0.8-0.41,0.95-0.61l1.42,1.42C12.26,10.21,11.41,11,10.25,11z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
