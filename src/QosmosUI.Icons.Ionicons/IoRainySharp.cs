// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoRainySharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M364,336H130c-29.5,0-54.92-7.83-73.53-22.64C35.23,296.44,24,271.35,24,240.8c0-26.66,10.08-49.8,29.14-66.91,15.24-13.68,36.17-23.21,59-26.84h0c.06,0,.08,0,.09-.05,6.44-39,23.83-72.09,50.31-95.68A140.24,140.24,0,0,1,256,16c30.23,0,58.48,9.39,81.71,27.17a142.69,142.69,0,0,1,45.36,60.66c29.41,4.82,54.72,17.11,73.19,35.54C477,160.11,488,187.71,488,219.2c0,32.85-13.13,62.87-37,84.52C428.11,324.54,397.2,336,364,336Zm19-232.18Z");
		builder.CloseElement();
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "87.16");
		builder.AddAttribute(17, "y", "386");
		builder.AddAttribute(18, "width", "89.69");
		builder.AddAttribute(19, "height", "32");
		builder.AddAttribute(20, "transform", "translate(-275.7 288.83) rotate(-56.31)");
		builder.CloseElement();
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "x", "122.31");
		builder.AddAttribute(23, "y", "410");
		builder.AddAttribute(24, "width", "147.38");
		builder.AddAttribute(25, "height", "32");
		builder.AddAttribute(26, "transform", "translate(-267.17 352.77) rotate(-56.31)");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "247.16");
		builder.AddAttribute(29, "y", "386");
		builder.AddAttribute(30, "width", "89.69");
		builder.AddAttribute(31, "height", "32");
		builder.AddAttribute(32, "transform", "translate(-204.46 421.96) rotate(-56.31)");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "x", "282.31");
		builder.AddAttribute(35, "y", "410");
		builder.AddAttribute(36, "width", "147.38");
		builder.AddAttribute(37, "height", "32");
		builder.AddAttribute(38, "transform", "translate(-195.93 485.9) rotate(-56.31)");
		builder.CloseElement();
		builder.CloseElement();
    }
}
