// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoWineOutline : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M398.57,80H113.43V96S87.51,272,256,272,398.57,96,398.57,96Z");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "x1", "256");
		builder.AddAttribute(20, "y1", "272");
		builder.AddAttribute(21, "x2", "256");
		builder.AddAttribute(22, "y2", "432");
		builder.AddAttribute(23, "fill", "none");
		builder.AddAttribute(24, "stroke-linejoin", "round");
		builder.AddAttribute(25, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(26, "line");
		builder.AddAttribute(27, "x1", "352");
		builder.AddAttribute(28, "y1", "432");
		builder.AddAttribute(29, "x2", "160");
		builder.AddAttribute(30, "y2", "432");
		builder.AddAttribute(31, "fill", "none");
		builder.AddAttribute(32, "stroke-linecap", "round");
		builder.AddAttribute(33, "stroke-linejoin", "round");
		builder.AddAttribute(34, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(35, "line");
		builder.AddAttribute(36, "x1", "112");
		builder.AddAttribute(37, "y1", "160");
		builder.AddAttribute(38, "x2", "400");
		builder.AddAttribute(39, "y2", "160");
		builder.AddAttribute(40, "fill", "none");
		builder.AddAttribute(41, "stroke-linejoin", "round");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
