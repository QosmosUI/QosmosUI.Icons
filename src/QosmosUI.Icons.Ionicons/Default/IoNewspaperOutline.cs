// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoNewspaperOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M368,415.86V72a24.07,24.07,0,0,0-24-24H72A24.07,24.07,0,0,0,48,72V424a40.12,40.12,0,0,0,40,40H416");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M416,464h0a48,48,0,0,1-48-48V128h72a24,24,0,0,1,24,24V416A48,48,0,0,1,416,464Z");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linejoin", "round");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "line");
		builder.AddAttribute(24, "x1", "240");
		builder.AddAttribute(25, "y1", "128");
		builder.AddAttribute(26, "x2", "304");
		builder.AddAttribute(27, "y2", "128");
		builder.AddAttribute(28, "fill", "none");
		builder.AddAttribute(29, "stroke-linecap", "round");
		builder.AddAttribute(30, "stroke-linejoin", "round");
		builder.AddAttribute(31, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(32, "line");
		builder.AddAttribute(33, "x1", "240");
		builder.AddAttribute(34, "y1", "192");
		builder.AddAttribute(35, "x2", "304");
		builder.AddAttribute(36, "y2", "192");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-linecap", "round");
		builder.AddAttribute(39, "stroke-linejoin", "round");
		builder.AddAttribute(40, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(41, "line");
		builder.AddAttribute(42, "x1", "112");
		builder.AddAttribute(43, "y1", "256");
		builder.AddAttribute(44, "x2", "304");
		builder.AddAttribute(45, "y2", "256");
		builder.AddAttribute(46, "fill", "none");
		builder.AddAttribute(47, "stroke-linecap", "round");
		builder.AddAttribute(48, "stroke-linejoin", "round");
		builder.AddAttribute(49, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(50, "line");
		builder.AddAttribute(51, "x1", "112");
		builder.AddAttribute(52, "y1", "320");
		builder.AddAttribute(53, "x2", "304");
		builder.AddAttribute(54, "y2", "320");
		builder.AddAttribute(55, "fill", "none");
		builder.AddAttribute(56, "stroke-linecap", "round");
		builder.AddAttribute(57, "stroke-linejoin", "round");
		builder.AddAttribute(58, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(59, "line");
		builder.AddAttribute(60, "x1", "112");
		builder.AddAttribute(61, "y1", "384");
		builder.AddAttribute(62, "x2", "304");
		builder.AddAttribute(63, "y2", "384");
		builder.AddAttribute(64, "fill", "none");
		builder.AddAttribute(65, "stroke-linecap", "round");
		builder.AddAttribute(66, "stroke-linejoin", "round");
		builder.AddAttribute(67, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(68, "path");
		builder.AddAttribute(69, "d", "M176,208H112a16,16,0,0,1-16-16V128a16,16,0,0,1,16-16h64a16,16,0,0,1,16,16v64A16,16,0,0,1,176,208Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
