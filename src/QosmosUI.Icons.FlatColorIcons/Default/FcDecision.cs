// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcDecision : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#FFCC80");
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "38");
		builder.AddAttribute(17, "cy", "26");
		builder.AddAttribute(18, "r", "4");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "10");
		builder.AddAttribute(21, "cy", "26");
		builder.AddAttribute(22, "r", "4");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M39,19c0-12.7-30-8.3-30,0c0,1.8,0,8.2,0,10c0,8.3,6.7,15,15,15s15-6.7,15-15C39,27.2,39,20.8,39,19z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M24,4C15.2,4,8,11.2,8,20c0,1.2,0,3.5,0,3.5l2.1,0.6V19l19.5-6.3l8.2,6.3v5.1l2.1-0.6c0,0,0-2.3,0-3.5 C40,12.5,34.6,4,24,4z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "fill", "#0277BD");
		builder.AddAttribute(29, "d", "M21.8,29.6c0-6.6,5.1-6.2,5.1-10.2c0-1-0.3-3-2.9-3c-2.8,0-3,2.3-3,2.8h-3.8c0-1,0.4-6,6.8-6 c6.5,0,6.7,5.1,6.7,6c0,4.9-5.4,5.6-5.4,10.3H21.8z M21.5,34.5c0-0.3,0.1-2.1,2.1-2.1c2,0,2.2,1.8,2.2,2.1c0,0.6-0.3,2-2.2,2 C21.8,36.5,21.5,35.1,21.5,34.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
