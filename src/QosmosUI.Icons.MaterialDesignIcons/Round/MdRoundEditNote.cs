// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundEditNote : ComponentBase
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
		builder.AddAttribute(18, "d", "M14,11c0,0.55-0.45,1-1,1H4c-0.55,0-1-0.45-1-1s0.45-1,1-1h9C13.55,10,14,10.45,14,11z M3,7c0,0.55,0.45,1,1,1h9 c0.55,0,1-0.45,1-1s-0.45-1-1-1H4C3.45,6,3,6.45,3,7z M10,15c0-0.55-0.45-1-1-1H4c-0.55,0-1,0.45-1,1s0.45,1,1,1h5 C9.55,16,10,15.55,10,15z M18.01,12.87l0.71-0.71c0.39-0.39,1.02-0.39,1.41,0l0.71,0.71c0.39,0.39,0.39,1.02,0,1.41l-0.71,0.71 L18.01,12.87z M17.3,13.58l-5.16,5.16C12.05,18.83,12,18.95,12,19.09v1.41c0,0.28,0.22,0.5,0.5,0.5h1.41c0.13,0,0.26-0.05,0.35-0.15 l5.16-5.16L17.3,13.58z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
