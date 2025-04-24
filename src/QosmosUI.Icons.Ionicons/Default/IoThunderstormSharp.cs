// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoThunderstormSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M405.84,136.9A151.25,151.25,0,0,0,358.24,55a153,153,0,0,0-241.81,51.86C60.5,110.16,16,156.65,16,213.33,16,272.15,63.91,320,122.8,320h72.31L176,416h48v80L336,352H292.49l8-32H404.33a91.56,91.56,0,0,0,1.51-183.1Z");
		builder.CloseElement();
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "65.17");
		builder.AddAttribute(17, "y", "360");
		builder.AddAttribute(18, "width", "85.67");
		builder.AddAttribute(19, "height", "32");
		builder.AddAttribute(20, "transform", "translate(-276.6 304.44) rotate(-63.43)");
		builder.CloseElement();
		builder.OpenElement(21, "rect");
		builder.AddAttribute(22, "x", "94.11");
		builder.AddAttribute(23, "y", "432");
		builder.AddAttribute(24, "width", "67.78");
		builder.AddAttribute(25, "height", "32");
		builder.AddAttribute(26, "transform", "translate(-329.95 362.13) rotate(-63.43)");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "345.17");
		builder.AddAttribute(29, "y", "360");
		builder.AddAttribute(30, "width", "85.67");
		builder.AddAttribute(31, "height", "32");
		builder.AddAttribute(32, "transform", "translate(-121.83 554.88) rotate(-63.43)");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "x", "374.11");
		builder.AddAttribute(35, "y", "432");
		builder.AddAttribute(36, "width", "67.78");
		builder.AddAttribute(37, "height", "32");
		builder.AddAttribute(38, "transform", "translate(-175.17 612.57) rotate(-63.43)");
		builder.CloseElement();
		builder.CloseElement();
    }
}
