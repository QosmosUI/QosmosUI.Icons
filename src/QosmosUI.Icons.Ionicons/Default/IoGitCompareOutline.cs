// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoGitCompareOutline : ComponentBase
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
		builder.OpenElement(13, "polyline");
		builder.AddAttribute(14, "points", "304 160 240 96 304 32");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "round");
		builder.AddAttribute(17, "stroke-linejoin", "round");
		builder.AddAttribute(18, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(19, "polyline");
		builder.AddAttribute(20, "points", "207 352 271 416 207 480");
		builder.AddAttribute(21, "fill", "none");
		builder.AddAttribute(22, "stroke-linecap", "round");
		builder.AddAttribute(23, "stroke-linejoin", "round");
		builder.AddAttribute(24, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "112");
		builder.AddAttribute(27, "cy", "96");
		builder.AddAttribute(28, "r", "48");
		builder.AddAttribute(29, "fill", "none");
		builder.AddAttribute(30, "stroke-linecap", "round");
		builder.AddAttribute(31, "stroke-linejoin", "round");
		builder.AddAttribute(32, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "400");
		builder.AddAttribute(35, "cy", "416");
		builder.AddAttribute(36, "r", "48");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-linecap", "round");
		builder.AddAttribute(39, "stroke-linejoin", "round");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M256,96h84a60,60,0,0,1,60,60V368");
		builder.AddAttribute(43, "fill", "none");
		builder.AddAttribute(44, "stroke-linecap", "round");
		builder.AddAttribute(45, "stroke-linejoin", "round");
		builder.AddAttribute(46, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(47, "path");
		builder.AddAttribute(48, "d", "M255,416H171a60,60,0,0,1-60-60V144");
		builder.AddAttribute(49, "fill", "none");
		builder.AddAttribute(50, "stroke-linecap", "round");
		builder.AddAttribute(51, "stroke-linejoin", "round");
		builder.AddAttribute(52, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
