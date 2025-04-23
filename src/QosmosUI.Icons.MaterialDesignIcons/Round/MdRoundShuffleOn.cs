// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundShuffleOn : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M21,1H3C1.9,1,1,1.9,1,3v18c0,1.1,0.9,2,2,2h18c1.1,0,2-0.9,2-2V3C23,1.9,22.1,1,21,1z M4.3,4.7 c0.39-0.39,1.02-0.39,1.41,0l4.47,4.47l-1.42,1.4L4.3,6.11C3.91,5.72,3.91,5.09,4.3,4.7z M19.59,19.5c0,0.28-0.22,0.5-0.5,0.5H15.3 c-0.45,0-0.67-0.54-0.36-0.85l1.2-1.2l-3.13-3.13l1.41-1.41l3.13,3.14l1.19-1.19c0.31-0.32,0.85-0.1,0.85,0.35V19.5z M19.59,8.29 c0,0.45-0.54,0.67-0.85,0.36l-1.19-1.19L5.7,19.29c-0.39,0.39-1.02,0.39-1.41,0c-0.39-0.39-0.39-1.02,0-1.41L16.13,6.04l-1.19-1.19 C14.63,4.54,14.85,4,15.3,4h3.79c0.28,0,0.5,0.22,0.5,0.5V8.29z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
