// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoBeerOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M352,200V440a40.12,40.12,0,0,1-40,40H136a40.12,40.12,0,0,1-40-40V224");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-linecap", "round");
		builder.AddAttribute(17, "stroke-linejoin", "round");
		builder.AddAttribute(18, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M352,224h40a56.16,56.16,0,0,1,56,56v80a56.16,56.16,0,0,1-56,56H352");
		builder.AddAttribute(21, "fill", "none");
		builder.AddAttribute(22, "stroke-linecap", "round");
		builder.AddAttribute(23, "stroke-miterlimit", "10");
		builder.AddAttribute(24, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(25, "line");
		builder.AddAttribute(26, "x1", "224");
		builder.AddAttribute(27, "y1", "256");
		builder.AddAttribute(28, "x2", "224");
		builder.AddAttribute(29, "y2", "416");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-linecap", "round");
		builder.AddAttribute(32, "stroke-linejoin", "round");
		builder.AddAttribute(33, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(34, "line");
		builder.AddAttribute(35, "x1", "288");
		builder.AddAttribute(36, "y1", "256");
		builder.AddAttribute(37, "x2", "288");
		builder.AddAttribute(38, "y2", "416");
		builder.AddAttribute(39, "fill", "none");
		builder.AddAttribute(40, "stroke-linecap", "round");
		builder.AddAttribute(41, "stroke-linejoin", "round");
		builder.AddAttribute(42, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(43, "line");
		builder.AddAttribute(44, "x1", "160");
		builder.AddAttribute(45, "y1", "256");
		builder.AddAttribute(46, "x2", "160");
		builder.AddAttribute(47, "y2", "416");
		builder.AddAttribute(48, "fill", "none");
		builder.AddAttribute(49, "stroke-linecap", "round");
		builder.AddAttribute(50, "stroke-linejoin", "round");
		builder.AddAttribute(51, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(52, "path");
		builder.AddAttribute(53, "d", "M320,112a48,48,0,0,1,0,96c-13.25,0-29.31-7.31-38-16H160c-8,22-27,32-48,32a48,48,0,0,1,0-96,47.91,47.91,0,0,1,26,9");
		builder.AddAttribute(54, "fill", "none");
		builder.AddAttribute(55, "stroke-linecap", "round");
		builder.AddAttribute(56, "stroke-linejoin", "round");
		builder.AddAttribute(57, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(58, "path");
		builder.AddAttribute(59, "d", "M91.86,132.43a40,40,0,1,1,60.46-52S160,91,160,96");
		builder.AddAttribute(60, "fill", "none");
		builder.AddAttribute(61, "stroke-linecap", "round");
		builder.AddAttribute(62, "stroke-miterlimit", "10");
		builder.AddAttribute(63, "stroke-width", "32px");
		builder.CloseElement();
		builder.OpenElement(64, "path");
		builder.AddAttribute(65, "d", "M145.83,64.71C163.22,44.89,187.57,32,216,32c52.38,0,94,42.84,94,95.21A95,95,0,0,1,308.33,145");
		builder.AddAttribute(66, "fill", "none");
		builder.AddAttribute(67, "stroke-linecap", "round");
		builder.AddAttribute(68, "stroke-miterlimit", "10");
		builder.AddAttribute(69, "stroke-width", "32px");
		builder.CloseElement();
		builder.CloseElement();
    }
}
