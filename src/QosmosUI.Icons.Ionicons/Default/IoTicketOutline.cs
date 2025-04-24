// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoTicketOutline : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-miterlimit", "10");
		builder.AddAttribute(16, "stroke-width", "32");
		builder.AddAttribute(17, "d", "M366.05,146a46.7,46.7,0,0,1-2.42-63.42,3.87,3.87,0,0,0-.22-5.26L319.28,33.14a3.89,3.89,0,0,0-5.5,0l-70.34,70.34a23.62,23.62,0,0,0-5.71,9.24h0a23.66,23.66,0,0,1-14.95,15h0a23.7,23.7,0,0,0-9.25,5.71L33.14,313.78a3.89,3.89,0,0,0,0,5.5l44.13,44.13a3.87,3.87,0,0,0,5.26.22,46.69,46.69,0,0,1,65.84,65.84,3.87,3.87,0,0,0,.22,5.26l44.13,44.13a3.89,3.89,0,0,0,5.5,0l180.4-180.39a23.7,23.7,0,0,0,5.71-9.25h0a23.66,23.66,0,0,1,14.95-15h0a23.62,23.62,0,0,0,9.24-5.71l70.34-70.34a3.89,3.89,0,0,0,0-5.5l-44.13-44.13a3.87,3.87,0,0,0-5.26-.22A46.7,46.7,0,0,1,366.05,146Z");
		builder.CloseElement();
		builder.OpenElement(18, "line");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "stroke-miterlimit", "10");
		builder.AddAttribute(21, "stroke-width", "32");
		builder.AddAttribute(22, "stroke-linecap", "round");
		builder.AddAttribute(23, "x1", "250.5");
		builder.AddAttribute(24, "y1", "140.44");
		builder.AddAttribute(25, "x2", "233.99");
		builder.AddAttribute(26, "y2", "123.93");
		builder.CloseElement();
		builder.OpenElement(27, "line");
		builder.AddAttribute(28, "fill", "none");
		builder.AddAttribute(29, "stroke-miterlimit", "10");
		builder.AddAttribute(30, "stroke-width", "32");
		builder.AddAttribute(31, "stroke-linecap", "round");
		builder.AddAttribute(32, "x1", "294.52");
		builder.AddAttribute(33, "y1", "184.46");
		builder.AddAttribute(34, "x2", "283.51");
		builder.AddAttribute(35, "y2", "173.46");
		builder.CloseElement();
		builder.OpenElement(36, "line");
		builder.AddAttribute(37, "fill", "none");
		builder.AddAttribute(38, "stroke-miterlimit", "10");
		builder.AddAttribute(39, "stroke-width", "32");
		builder.AddAttribute(40, "stroke-linecap", "round");
		builder.AddAttribute(41, "x1", "338.54");
		builder.AddAttribute(42, "y1", "228.49");
		builder.AddAttribute(43, "x2", "327.54");
		builder.AddAttribute(44, "y2", "217.48");
		builder.CloseElement();
		builder.OpenElement(45, "line");
		builder.AddAttribute(46, "fill", "none");
		builder.AddAttribute(47, "stroke-miterlimit", "10");
		builder.AddAttribute(48, "stroke-width", "32");
		builder.AddAttribute(49, "stroke-linecap", "round");
		builder.AddAttribute(50, "x1", "388.07");
		builder.AddAttribute(51, "y1", "278.01");
		builder.AddAttribute(52, "x2", "371.56");
		builder.AddAttribute(53, "y2", "261.5");
		builder.CloseElement();
		builder.CloseElement();
    }
}
