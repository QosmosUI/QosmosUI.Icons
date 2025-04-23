// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoListCircleOutline : ComponentBase
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
		builder.OpenElement(13, "line");
		builder.AddAttribute(14, "x1", "224");
		builder.AddAttribute(15, "y1", "184");
		builder.AddAttribute(16, "x2", "352");
		builder.AddAttribute(17, "y2", "184");
		builder.AddAttribute(18, "fill", "none");
		builder.AddAttribute(19, "stroke-linecap", "round");
		builder.AddAttribute(20, "stroke-linejoin", "round");
		builder.AddAttribute(21, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(22, "line");
		builder.AddAttribute(23, "x1", "224");
		builder.AddAttribute(24, "y1", "256");
		builder.AddAttribute(25, "x2", "352");
		builder.AddAttribute(26, "y2", "256");
		builder.AddAttribute(27, "fill", "none");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "stroke-linejoin", "round");
		builder.AddAttribute(30, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "x1", "224");
		builder.AddAttribute(33, "y1", "327");
		builder.AddAttribute(34, "x2", "352");
		builder.AddAttribute(35, "y2", "327");
		builder.AddAttribute(36, "fill", "none");
		builder.AddAttribute(37, "stroke-linecap", "round");
		builder.AddAttribute(38, "stroke-linejoin", "round");
		builder.AddAttribute(39, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M448,258c0-106-86-192-192-192S64,152,64,258s86,192,192,192S448,364,448,258Z");
		builder.AddAttribute(42, "fill", "none");
		builder.AddAttribute(43, "stroke-miterlimit", "10");
		builder.AddAttribute(44, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(45, "circle");
		builder.AddAttribute(46, "cx", "168");
		builder.AddAttribute(47, "cy", "184");
		builder.AddAttribute(48, "r", "8");
		builder.AddAttribute(49, "fill", "none");
		builder.AddAttribute(50, "stroke-linecap", "round");
		builder.AddAttribute(51, "stroke-linejoin", "round");
		builder.AddAttribute(52, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(53, "circle");
		builder.AddAttribute(54, "cx", "168");
		builder.AddAttribute(55, "cy", "257");
		builder.AddAttribute(56, "r", "8");
		builder.AddAttribute(57, "fill", "none");
		builder.AddAttribute(58, "stroke-linecap", "round");
		builder.AddAttribute(59, "stroke-linejoin", "round");
		builder.AddAttribute(60, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(61, "circle");
		builder.AddAttribute(62, "cx", "168");
		builder.AddAttribute(63, "cy", "328");
		builder.AddAttribute(64, "r", "8");
		builder.AddAttribute(65, "fill", "none");
		builder.AddAttribute(66, "stroke-linecap", "round");
		builder.AddAttribute(67, "stroke-linejoin", "round");
		builder.AddAttribute(68, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
