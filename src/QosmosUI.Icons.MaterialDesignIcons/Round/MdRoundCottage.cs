// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCottage : ComponentBase
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
		builder.AddAttribute(18, "d", "M22.39,12.19c0.34-0.44,0.25-1.07-0.19-1.4l-9.6-7.33c-0.36-0.27-0.86-0.27-1.21,0L6,7.58V7c0-0.55-0.45-1-1-1S4,6.45,4,7 v2.11l-2.21,1.68c-0.44,0.33-0.52,0.96-0.19,1.4c0.34,0.44,0.96,0.52,1.4,0.19L4,11.62V20c0,0.55,0.45,1,1,1h6v-5c0-0.55,0.45-1,1-1 s1,0.45,1,1v5h6c0.55,0,1-0.45,1-1v-8.38l0.99,0.76C21.43,12.72,22.06,12.63,22.39,12.19z M5.27,5c-0.74,0-1.26-0.8-0.9-1.45 C4.89,2.62,5.87,2,7,2c0.38,0,0.72-0.22,0.89-0.53C8.04,1.16,8.39,1,8.73,1c0.74,0,1.26,0.8,0.9,1.45C9.11,3.38,8.13,4,7,4 C6.62,4,6.28,4.22,6.11,4.53C5.96,4.84,5.61,5,5.27,5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
