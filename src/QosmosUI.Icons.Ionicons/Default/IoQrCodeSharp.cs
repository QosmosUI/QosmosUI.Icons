// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoQrCodeSharp : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "336");
		builder.AddAttribute(15, "y", "336");
		builder.AddAttribute(16, "width", "80");
		builder.AddAttribute(17, "height", "80");
		builder.CloseElement();
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "x", "272");
		builder.AddAttribute(20, "y", "272");
		builder.AddAttribute(21, "width", "64");
		builder.AddAttribute(22, "height", "64");
		builder.CloseElement();
		builder.OpenElement(23, "rect");
		builder.AddAttribute(24, "x", "416");
		builder.AddAttribute(25, "y", "416");
		builder.AddAttribute(26, "width", "64");
		builder.AddAttribute(27, "height", "64");
		builder.CloseElement();
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "x", "432");
		builder.AddAttribute(30, "y", "272");
		builder.AddAttribute(31, "width", "48");
		builder.AddAttribute(32, "height", "48");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "x", "272");
		builder.AddAttribute(35, "y", "432");
		builder.AddAttribute(36, "width", "48");
		builder.AddAttribute(37, "height", "48");
		builder.CloseElement();
		builder.OpenElement(38, "rect");
		builder.AddAttribute(39, "x", "336");
		builder.AddAttribute(40, "y", "96");
		builder.AddAttribute(41, "width", "80");
		builder.AddAttribute(42, "height", "80");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M480,240H272V32H480ZM316,196H436V76H316Z");
		builder.CloseElement();
		builder.OpenElement(45, "rect");
		builder.AddAttribute(46, "x", "96");
		builder.AddAttribute(47, "y", "96");
		builder.AddAttribute(48, "width", "80");
		builder.AddAttribute(49, "height", "80");
		builder.CloseElement();
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M240,240H32V32H240ZM76,196H196V76H76Z");
		builder.CloseElement();
		builder.OpenElement(52, "rect");
		builder.AddAttribute(53, "x", "96");
		builder.AddAttribute(54, "y", "336");
		builder.AddAttribute(55, "width", "80");
		builder.AddAttribute(56, "height", "80");
		builder.CloseElement();
		builder.OpenElement(57, "path");
		builder.AddAttribute(58, "d", "M240,480H32V272H240ZM76,436H196V316H76Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
