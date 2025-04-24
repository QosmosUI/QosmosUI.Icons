// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcMultipleCameras : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#455A64");
		builder.AddAttribute(15, "d", "M42,41H12c-2.2,0-4-1.8-4-4V17c0-2.2,1.8-4,4-4h30c2.2,0,4,1.8,4,4v20C46,39.2,44.2,41,42,41z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#78909C");
		builder.AddAttribute(18, "d", "M36,36H6c-2.2,0-4-1.8-4-4V12c0-2.2,1.8-4,4-4h30c2.2,0,4,1.8,4,4v20C40,34.2,38.2,36,36,36z");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#455A64");
		builder.AddAttribute(21, "cx", "26");
		builder.AddAttribute(22, "cy", "22");
		builder.AddAttribute(23, "r", "10");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "fill", "#42A5F5");
		builder.AddAttribute(26, "cx", "26");
		builder.AddAttribute(27, "cy", "22");
		builder.AddAttribute(28, "r", "7");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "fill", "#90CAF9");
		builder.AddAttribute(31, "d", "M29.7,19.7c-1-1.1-2.3-1.7-3.7-1.7s-2.8,0.6-3.7,1.7c-0.4,0.4-0.3,1,0.1,1.4c0.4,0.4,1,0.3,1.4-0.1 c1.2-1.3,3.3-1.3,4.5,0c0.2,0.2,0.5,0.3,0.7,0.3c0.2,0,0.5-0.1,0.7-0.3C30.1,20.7,30.1,20.1,29.7,19.7z");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "6");
		builder.AddAttribute(34, "y", "12");
		builder.AddAttribute(35, "fill", "#ADD8FB");
		builder.AddAttribute(36, "width", "6");
		builder.AddAttribute(37, "height", "3");
		builder.CloseElement();
		builder.CloseElement();
    }
}
