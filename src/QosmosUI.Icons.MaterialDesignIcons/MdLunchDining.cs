// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdLunchDining : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M22,10c0.32-3.28-4.28-6-9.99-6C6.3,4,1.7,6.72,2.02,10H22z");
		builder.AddAttribute(22, "fill-rule", "evenodd");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M5.35,13.5c0.55,0,0.78,0.14,1.15,0.36c0.45,0.27,1.07,0.64,2.18,0.64 s1.73-0.37,2.18-0.64c0.37-0.23,0.59-0.36,1.15-0.36c0.55,0,0.78,0.14,1.15,0.36c0.45,0.27,1.07,0.64,2.18,0.64 c1.11,0,1.73-0.37,2.18-0.64c0.37-0.23,0.59-0.36,1.15-0.36c0.55,0,0.78,0.14,1.15,0.36c0.45,0.27,1.07,0.63,2.17,0.64v-1.98 c0,0-0.79-0.16-1.16-0.38c-0.45-0.27-1.07-0.64-2.18-0.64c-1.11,0-1.73,0.37-2.18,0.64c-0.37,0.23-0.6,0.36-1.15,0.36 s-0.78-0.14-1.15-0.36c-0.45-0.27-1.07-0.64-2.18-0.64s-1.73,0.37-2.18,0.64c-0.37,0.23-0.59,0.36-1.15,0.36 c-0.55,0-0.78-0.14-1.15-0.36c-0.45-0.27-1.07-0.64-2.18-0.64c-1.11,0-1.73,0.37-2.18,0.64C2.78,12.37,2.56,12.5,2,12.5v2 c1.11,0,1.73-0.37,2.21-0.64C4.58,13.63,4.8,13.5,5.35,13.5z");
		builder.AddAttribute(25, "fill-rule", "evenodd");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M2,16v2c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2v-2H2z");
		builder.AddAttribute(28, "fill-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
