// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoRibbonOutline : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "256");
		builder.AddAttribute(15, "cy", "160");
		builder.AddAttribute(16, "r", "128");
		builder.AddAttribute(17, "fill", "none");
		builder.AddAttribute(18, "stroke-linecap", "round");
		builder.AddAttribute(19, "stroke-linejoin", "round");
		builder.AddAttribute(20, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M143.65,227.82,48,400l86.86-.42a16,16,0,0,1,13.82,7.8L192,480l88.33-194.32");
		builder.AddAttribute(23, "fill", "none");
		builder.AddAttribute(24, "stroke-linecap", "round");
		builder.AddAttribute(25, "stroke-linejoin", "round");
		builder.AddAttribute(26, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M366.54,224,464,400l-86.86-.42a16,16,0,0,0-13.82,7.8L320,480,256,339.2");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "256");
		builder.AddAttribute(35, "cy", "160");
		builder.AddAttribute(36, "r", "64");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-linecap", "round");
		builder.AddAttribute(39, "stroke-linejoin", "round");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
