// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoMagnetOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M421.83,293.82A144,144,0,0,0,218.18,90.17");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-miterlimit", "10");
		builder.AddAttribute(17, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M353.94,225.94a48,48,0,0,0-67.88-67.88");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-miterlimit", "10");
		builder.AddAttribute(22, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(23, "line");
		builder.AddAttribute(24, "x1", "192");
		builder.AddAttribute(25, "y1", "464");
		builder.AddAttribute(26, "x2", "192");
		builder.AddAttribute(27, "y2", "416");
		builder.AddAttribute(28, "stroke-linecap", "round");
		builder.AddAttribute(29, "stroke-miterlimit", "10");
		builder.AddAttribute(30, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "x1", "90.18");
		builder.AddAttribute(33, "y1", "421.82");
		builder.AddAttribute(34, "x2", "124.12");
		builder.AddAttribute(35, "y2", "387.88");
		builder.AddAttribute(36, "stroke-linecap", "round");
		builder.AddAttribute(37, "stroke-miterlimit", "10");
		builder.AddAttribute(38, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(39, "line");
		builder.AddAttribute(40, "x1", "48");
		builder.AddAttribute(41, "y1", "320");
		builder.AddAttribute(42, "x2", "96");
		builder.AddAttribute(43, "y2", "320");
		builder.AddAttribute(44, "stroke-linecap", "round");
		builder.AddAttribute(45, "stroke-miterlimit", "10");
		builder.AddAttribute(46, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(47, "path");
		builder.AddAttribute(48, "d", "M286.06,158.06,172.92,271.19a32,32,0,0,1-45.25,0L105,248.57a32,32,0,0,1,0-45.26L218.18,90.17");
		builder.AddAttribute(49, "fill", "none");
		builder.AddAttribute(50, "stroke-linejoin", "round");
		builder.AddAttribute(51, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(52, "path");
		builder.AddAttribute(53, "d", "M421.83,293.82,308.69,407a32,32,0,0,1-45.26,0l-22.62-22.63a32,32,0,0,1,0-45.26L353.94,225.94");
		builder.AddAttribute(54, "fill", "none");
		builder.AddAttribute(55, "stroke-linejoin", "round");
		builder.AddAttribute(56, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(57, "line");
		builder.AddAttribute(58, "x1", "139.6");
		builder.AddAttribute(59, "y1", "169.98");
		builder.AddAttribute(60, "x2", "207.48");
		builder.AddAttribute(61, "y2", "237.87");
		builder.AddAttribute(62, "fill", "none");
		builder.AddAttribute(63, "stroke-linejoin", "round");
		builder.AddAttribute(64, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(65, "line");
		builder.AddAttribute(66, "x1", "275.36");
		builder.AddAttribute(67, "y1", "305.75");
		builder.AddAttribute(68, "x2", "343.25");
		builder.AddAttribute(69, "y2", "373.63");
		builder.AddAttribute(70, "fill", "none");
		builder.AddAttribute(71, "stroke-linejoin", "round");
		builder.AddAttribute(72, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
