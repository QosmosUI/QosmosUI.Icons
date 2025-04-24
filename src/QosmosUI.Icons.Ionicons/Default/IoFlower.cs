// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoFlower : ComponentBase
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
		builder.AddAttribute(15, "cy", "256");
		builder.AddAttribute(16, "r", "48");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M475.93,303.91a67.49,67.49,0,0,0-44.34-115.53,5.2,5.2,0,0,1-4.58-3.21h0a5.21,5.21,0,0,1,1-5.51A67.83,67.83,0,0,0,378,66.33h-.25A67.13,67.13,0,0,0,332.35,84a5.21,5.21,0,0,1-5.52,1h0a5.23,5.23,0,0,1-3.22-4.58,67.68,67.68,0,0,0-135.23,0A5.2,5.2,0,0,1,185.17,85h0a5.21,5.21,0,0,1-5.52-1,67.11,67.11,0,0,0-45.44-17.69H134A67.91,67.91,0,0,0,84,179.65a5.21,5.21,0,0,1,1,5.51h0a5.2,5.2,0,0,1-4.58,3.21,67.71,67.71,0,0,0,0,135.23A5.23,5.23,0,0,1,85,326.83h0a5.22,5.22,0,0,1-1,5.52,67.54,67.54,0,0,0,50.08,113h.25A67.38,67.38,0,0,0,179.65,428a5.21,5.21,0,0,1,5.51-1h0a5.2,5.2,0,0,1,3.21,4.58,67.71,67.71,0,0,0,135.23,0,5.23,5.23,0,0,1,3.22-4.58h0a5.21,5.21,0,0,1,5.51,1,67.38,67.38,0,0,0,45.29,17.42h.25a67.48,67.48,0,0,0,50.08-113,5.22,5.22,0,0,1-1-5.52h0a5.23,5.23,0,0,1,4.58-3.22A67.31,67.31,0,0,0,475.93,303.91ZM256,336a80,80,0,1,1,80-80A80.09,80.09,0,0,1,256,336Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
