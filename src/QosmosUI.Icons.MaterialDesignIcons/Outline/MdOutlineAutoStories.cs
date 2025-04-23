// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineAutoStories : ComponentBase
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
		builder.AddAttribute(18, "x", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M22.47,5.2C22,4.96,21.51,4.76,21,4.59v12.03C19.86,16.21,18.69,16,17.5,16c-1.9,0-3.78,0.54-5.5,1.58V5.48 C10.38,4.55,8.51,4,6.5,4C4.71,4,3.02,4.44,1.53,5.2C1.2,5.36,1,5.71,1,6.08v12.08c0,0.58,0.47,0.99,1,0.99 c0.16,0,0.32-0.04,0.48-0.12C3.69,18.4,5.05,18,6.5,18c2.07,0,3.98,0.82,5.5,2c1.52-1.18,3.43-2,5.5-2c1.45,0,2.81,0.4,4.02,1.04 c0.16,0.08,0.32,0.12,0.48,0.12c0.52,0,1-0.41,1-0.99V6.08C23,5.71,22.8,5.36,22.47,5.2z M10,16.62C8.86,16.21,7.69,16,6.5,16 c-1.19,0-2.36,0.21-3.5,0.62V6.71C4.11,6.24,5.28,6,6.5,6C7.7,6,8.89,6.25,10,6.72V16.62z M19,0.5l-5,5V15l5-4.5V0.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
