// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundTroubleshoot : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M21.29,19.88l-3.98-3.98c1.3-1.67,1.96-3.85,1.58-6.2c-0.54-3.41-3.33-6.14-6.75-6.62C7.57,2.44,3.61,5.69,3.07,10h2.02 c0.53-3.13,3.48-5.44,6.85-4.93c2.61,0.4,4.7,2.57,5.02,5.2C17.39,13.9,14.55,17,11,17c-2.42,0-4.5-1.44-5.45-3.5H3.4 C4.45,16.69,7.46,19,11,19c1.85,0,3.55-0.63,4.9-1.69l3.98,3.98c0.39,0.39,1.02,0.39,1.41,0l0,0 C21.68,20.9,21.68,20.27,21.29,19.88z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M8.43,9.69l1.03,4.47C9.57,14.65,10.01,15,10.51,15h0c0.46,0,0.87-0.3,1.02-0.74l1.01-3.04l0.69,1.66 c0.16,0.37,0.52,0.62,0.92,0.62h0.58c0.41,0,0.75-0.34,0.75-0.75v0c0-0.41-0.34-0.75-0.75-0.75H14.5l-0.97-2.34 C13.36,9.26,12.97,9,12.53,9h-0.05c-0.46,0-0.87,0.3-1.02,0.74l-0.88,2.63L9.54,7.83C9.43,7.35,8.99,7,8.49,7h0 C8.02,7,7.6,7.31,7.46,7.76L6.45,11h-4.7C1.34,11,1,11.34,1,11.75v0c0,0.41,0.34,0.75,0.75,0.75h5.07c0.44,0,0.82-0.28,0.95-0.7 L8.43,9.69z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
