// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineStorm : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M18.93,8C16.72,4.18,11.82,2.87,8,5.07c-1.41,0.82-2.48,2-3.16,3.37C4.71,6.24,5.06,4.04,5.86,2H3.74 C2.2,6.49,2.52,11.58,5.07,16c1.1,1.91,2.88,3.19,4.86,3.72c1.98,0.53,4.16,0.31,6.07-0.79c1.41-0.82,2.48-2,3.16-3.37 c0.13,2.2-0.21,4.4-1.01,6.44h2.11C21.79,17.51,21.48,12.42,18.93,8z M15,17.2c-2.87,1.65-6.54,0.67-8.2-2.2 c-0.11-0.2-0.21-0.4-0.3-0.6C5.3,11.64,6.33,8.34,9,6.8c2.86-1.65,6.54-0.67,8.2,2.2c0.11,0.2,0.21,0.4,0.3,0.6 C18.7,12.36,17.67,15.66,15,17.2z M12,10c1.1,0,2,0.9,2,2s-0.9,2-2,2s-2-0.9-2-2S10.9,10,12,10 M12,8c-2.21,0-4,1.79-4,4 s1.79,4,4,4s4-1.79,4-4S14.21,8,12,8z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
