// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpDiversity1 : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "4");
		builder.AddAttribute(22, "cy", "14");
		builder.AddAttribute(23, "r", "2");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M1.22,17.58C0.48,17.9,0,18.62,0,19.43V21l4.5,0v-1.61c0-0.83,0.23-1.61,0.63-2.29C4.76,17.04,4.39,17,4,17 C3.01,17,2.07,17.21,1.22,17.58z");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "20");
		builder.AddAttribute(28, "cy", "14");
		builder.AddAttribute(29, "r", "2");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M22.78,17.58C21.93,17.21,20.99,17,20,17c-0.39,0-0.76,0.04-1.13,0.1c0.4,0.68,0.63,1.46,0.63,2.29V21l4.5,0v-1.57 C24,18.62,23.52,17.9,22.78,17.58z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M16.24,16.65c-1.17-0.52-2.61-0.9-4.24-0.9c-1.63,0-3.07,0.39-4.24,0.9C6.68,17.13,6,18.21,6,19.39V21h12v-1.61 C18,18.21,17.32,17.13,16.24,16.65z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M9,12c0,1.66,1.34,3,3,3s3-1.34,3-3c0-1.66-1.34-3-3-3S9,10.34,9,12z");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M2.48,10.86C2.17,10.1,2,9.36,2,8.6C2,6.02,4.02,4,6.6,4c2.68,0,3.82,1.74,5.4,3.59C13.57,5.76,14.7,4,17.4,4 C19.98,4,22,6.02,22,8.6c0,0.76-0.17,1.5-0.48,2.26c0.65,0.31,1.18,0.82,1.53,1.44C23.65,11.1,24,9.88,24,8.6 C24,4.9,21.1,2,17.4,2c-2.09,0-4.09,0.97-5.4,2.51C10.69,2.97,8.69,2,6.6,2C2.9,2,0,4.9,0,8.6c0,1.28,0.35,2.5,0.96,3.7 C1.31,11.68,1.84,11.17,2.48,10.86z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
