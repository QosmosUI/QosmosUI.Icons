// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoRadio : ComponentBase
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
		builder.AddAttribute(16, "r", "36");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M190.24,341.77a22,22,0,0,1-16.46-7.38,118,118,0,0,1,0-156.76,22,22,0,1,1,32.87,29.24,74,74,0,0,0,0,98.29,22,22,0,0,1-16.43,36.61Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M321.76,341.77a22,22,0,0,1-16.43-36.61,74,74,0,0,0,0-98.29,22,22,0,1,1,32.87-29.24,118,118,0,0,1,0,156.76A22,22,0,0,1,321.76,341.77Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M139.29,392.72a21.92,21.92,0,0,1-16.08-7,190,190,0,0,1,0-259.49,22,22,0,1,1,32.13,30.06,146,146,0,0,0,0,199.38,22,22,0,0,1-16.06,37Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M372.71,392.72a22,22,0,0,1-16.06-37,146,146,0,0,0,0-199.38,22,22,0,1,1,32.13-30.06,190,190,0,0,1,0,259.49A21.92,21.92,0,0,1,372.71,392.72Z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M429,438a22,22,0,0,1-16.39-36.67,218.34,218.34,0,0,0,0-290.66,22,22,0,0,1,32.78-29.34,262.34,262.34,0,0,1,0,349.34A22,22,0,0,1,429,438Z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M83,438a21.94,21.94,0,0,1-16.41-7.33,262.34,262.34,0,0,1,0-349.34,22,22,0,0,1,32.78,29.34,218.34,218.34,0,0,0,0,290.66A22,22,0,0,1,83,438Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
