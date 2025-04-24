// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoTrashBinOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M432,144,403.33,419.74A32,32,0,0,1,371.55,448H140.46a32,32,0,0,1-31.78-28.26L80,144");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "round");
		builder.AddAttribute(17, "stroke-linejoin", "round");
		builder.AddAttribute(18, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "32");
		builder.AddAttribute(21, "y", "64");
		builder.AddAttribute(22, "width", "448");
		builder.AddAttribute(23, "height", "80");
		builder.AddAttribute(24, "rx", "16");
		builder.AddAttribute(25, "ry", "16");
		builder.AddAttribute(26, "fill", "none");
		builder.AddAttribute(27, "stroke-linecap", "round");
		builder.AddAttribute(28, "stroke-linejoin", "round");
		builder.AddAttribute(29, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(30, "line");
		builder.AddAttribute(31, "x1", "312");
		builder.AddAttribute(32, "y1", "240");
		builder.AddAttribute(33, "x2", "200");
		builder.AddAttribute(34, "y2", "352");
		builder.AddAttribute(35, "fill", "none");
		builder.AddAttribute(36, "stroke-linecap", "round");
		builder.AddAttribute(37, "stroke-linejoin", "round");
		builder.AddAttribute(38, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(39, "line");
		builder.AddAttribute(40, "x1", "312");
		builder.AddAttribute(41, "y1", "352");
		builder.AddAttribute(42, "x2", "200");
		builder.AddAttribute(43, "y2", "240");
		builder.AddAttribute(44, "fill", "none");
		builder.AddAttribute(45, "stroke-linecap", "round");
		builder.AddAttribute(46, "stroke-linejoin", "round");
		builder.AddAttribute(47, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
