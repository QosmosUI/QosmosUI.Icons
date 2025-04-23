// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundTapas : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M22,10V2c0-0.55-0.45-1-1-1h-6c-0.55,0-1,0.45-1,1v8c0,1.86,1.28,3.41,3,3.86V21h-1c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1 h4c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h-1v-7.14C20.72,13.41,22,11.86,22,10z M20,3v3h-4V3H20z M9.86,9L8,9V8l1.86,0 c1.31,0,2.5-0.94,2.63-2.24C12.64,4.26,11.47,3,10,3H8V2c0-0.55-0.45-1-1-1h0C6.45,1,6,1.45,6,2v1L4.14,3 c-1.31,0-2.5,0.94-2.63,2.24C1.36,6.74,2.53,8,4,8h2v1L4.14,9c-1.31,0-2.5,0.94-2.63,2.24C1.36,12.74,2.53,14,4,14h2v8 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-8h2c1.47,0,2.64-1.26,2.49-2.76C12.36,9.94,11.17,9,9.86,9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
