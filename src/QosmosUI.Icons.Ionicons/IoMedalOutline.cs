// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoMedalOutline : ComponentBase
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
		builder.AddAttribute(15, "cy", "352");
		builder.AddAttribute(16, "r", "112");
		builder.AddAttribute(17, "fill", "none");
		builder.AddAttribute(18, "stroke-linecap", "round");
		builder.AddAttribute(19, "stroke-linejoin", "round");
		builder.AddAttribute(20, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "cx", "256");
		builder.AddAttribute(23, "cy", "352");
		builder.AddAttribute(24, "r", "48");
		builder.AddAttribute(25, "fill", "none");
		builder.AddAttribute(26, "stroke-linecap", "round");
		builder.AddAttribute(27, "stroke-linejoin", "round");
		builder.AddAttribute(28, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M147,323,41.84,159.32a32,32,0,0,1-1.7-31.61l31-62A32,32,0,0,1,99.78,48H412.22a32,32,0,0,1,28.62,17.69l31,62a32,32,0,0,1-1.7,31.61L365,323");
		builder.AddAttribute(31, "fill", "none");
		builder.AddAttribute(32, "stroke-linecap", "round");
		builder.AddAttribute(33, "stroke-linejoin", "round");
		builder.AddAttribute(34, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(35, "line");
		builder.AddAttribute(36, "x1", "371");
		builder.AddAttribute(37, "y1", "144");
		builder.AddAttribute(38, "x2", "37");
		builder.AddAttribute(39, "y2", "144");
		builder.AddAttribute(40, "fill", "none");
		builder.AddAttribute(41, "stroke-linecap", "round");
		builder.AddAttribute(42, "stroke-linejoin", "round");
		builder.AddAttribute(43, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(44, "line");
		builder.AddAttribute(45, "x1", "428.74");
		builder.AddAttribute(46, "y1", "52.6");
		builder.AddAttribute(47, "x2", "305");
		builder.AddAttribute(48, "y2", "250");
		builder.AddAttribute(49, "fill", "none");
		builder.AddAttribute(50, "stroke-linecap", "round");
		builder.AddAttribute(51, "stroke-linejoin", "round");
		builder.AddAttribute(52, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(53, "line");
		builder.AddAttribute(54, "x1", "140.55");
		builder.AddAttribute(55, "y1", "144");
		builder.AddAttribute(56, "x2", "207");
		builder.AddAttribute(57, "y2", "250");
		builder.AddAttribute(58, "fill", "none");
		builder.AddAttribute(59, "stroke-linecap", "round");
		builder.AddAttribute(60, "stroke-linejoin", "round");
		builder.AddAttribute(61, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
