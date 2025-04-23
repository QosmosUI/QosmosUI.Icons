// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoLogoAppleAr : ComponentBase
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
		builder.AddAttribute(14, "points", "201.14 64 256 32 310.86 64");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "round");
		builder.AddAttribute(17, "stroke-linejoin", "round");
		builder.AddAttribute(18, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(19, "line");
		builder.AddAttribute(20, "x1", "256");
		builder.AddAttribute(21, "y1", "32");
		builder.AddAttribute(22, "x2", "256");
		builder.AddAttribute(23, "y2", "112");
		builder.AddAttribute(24, "fill", "none");
		builder.AddAttribute(25, "stroke-linecap", "round");
		builder.AddAttribute(26, "stroke-miterlimit", "10");
		builder.AddAttribute(27, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(28, "polyline");
		builder.AddAttribute(29, "points", "310.86 448 256 480 201.14 448");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linecap", "round");
		builder.AddAttribute(32, "stroke-linejoin", "round");
		builder.AddAttribute(33, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(34, "line");
		builder.AddAttribute(35, "x1", "256");
		builder.AddAttribute(36, "y1", "480");
		builder.AddAttribute(37, "x2", "256");
		builder.AddAttribute(38, "y2", "400");
		builder.AddAttribute(39, "fill", "none");
		builder.AddAttribute(40, "stroke-linecap", "round");
		builder.AddAttribute(41, "stroke-miterlimit", "10");
		builder.AddAttribute(42, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(43, "polyline");
		builder.AddAttribute(44, "points", "64 207.51 64 144 117.15 112.49");
		builder.AddAttribute(45, "fill", "none");
		builder.AddAttribute(46, "stroke-linecap", "round");
		builder.AddAttribute(47, "stroke-linejoin", "round");
		builder.AddAttribute(48, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(49, "line");
		builder.AddAttribute(50, "x1", "64");
		builder.AddAttribute(51, "y1", "144");
		builder.AddAttribute(52, "x2", "131.29");
		builder.AddAttribute(53, "y2", "184");
		builder.AddAttribute(54, "fill", "none");
		builder.AddAttribute(55, "stroke-linecap", "round");
		builder.AddAttribute(56, "stroke-miterlimit", "10");
		builder.AddAttribute(57, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(58, "polyline");
		builder.AddAttribute(59, "points", "448 304.49 448 368 394.85 399.51");
		builder.AddAttribute(60, "fill", "none");
		builder.AddAttribute(61, "stroke-linecap", "round");
		builder.AddAttribute(62, "stroke-linejoin", "round");
		builder.AddAttribute(63, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(64, "line");
		builder.AddAttribute(65, "x1", "448");
		builder.AddAttribute(66, "y1", "368");
		builder.AddAttribute(67, "x2", "380.71");
		builder.AddAttribute(68, "y2", "328");
		builder.AddAttribute(69, "fill", "none");
		builder.AddAttribute(70, "stroke-linecap", "round");
		builder.AddAttribute(71, "stroke-miterlimit", "10");
		builder.AddAttribute(72, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(73, "polyline");
		builder.AddAttribute(74, "points", "117.15 400 64 368 64 304.49");
		builder.AddAttribute(75, "fill", "none");
		builder.AddAttribute(76, "stroke-linecap", "round");
		builder.AddAttribute(77, "stroke-linejoin", "round");
		builder.AddAttribute(78, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(79, "line");
		builder.AddAttribute(80, "x1", "64");
		builder.AddAttribute(81, "y1", "368");
		builder.AddAttribute(82, "x2", "130.64");
		builder.AddAttribute(83, "y2", "328");
		builder.AddAttribute(84, "fill", "none");
		builder.AddAttribute(85, "stroke-linecap", "round");
		builder.AddAttribute(86, "stroke-miterlimit", "10");
		builder.AddAttribute(87, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(88, "polyline");
		builder.AddAttribute(89, "points", "394.85 112.49 448 144 448 207.51");
		builder.AddAttribute(90, "fill", "none");
		builder.AddAttribute(91, "stroke-linecap", "round");
		builder.AddAttribute(92, "stroke-linejoin", "round");
		builder.AddAttribute(93, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(94, "line");
		builder.AddAttribute(95, "x1", "448");
		builder.AddAttribute(96, "y1", "144");
		builder.AddAttribute(97, "x2", "380.71");
		builder.AddAttribute(98, "y2", "184");
		builder.AddAttribute(99, "fill", "none");
		builder.AddAttribute(100, "stroke-linecap", "round");
		builder.AddAttribute(101, "stroke-miterlimit", "10");
		builder.AddAttribute(102, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(103, "polyline");
		builder.AddAttribute(104, "points", "256 320 256 256 310.86 224");
		builder.AddAttribute(105, "fill", "none");
		builder.AddAttribute(106, "stroke-linecap", "round");
		builder.AddAttribute(107, "stroke-miterlimit", "10");
		builder.AddAttribute(108, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(109, "line");
		builder.AddAttribute(110, "x1", "256");
		builder.AddAttribute(111, "y1", "256");
		builder.AddAttribute(112, "x2", "201.14");
		builder.AddAttribute(113, "y2", "224");
		builder.AddAttribute(114, "fill", "none");
		builder.AddAttribute(115, "stroke-linecap", "round");
		builder.AddAttribute(116, "stroke-miterlimit", "10");
		builder.AddAttribute(117, "stroke-width", "32");
		builder.CloseElement();
		builder.CloseElement();
    }
}
