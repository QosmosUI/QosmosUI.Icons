// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundStorm : ComponentBase
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
		builder.AddAttribute(20, "d", "M18.93,8C16.72,4.18,11.82,2.87,8,5.07c-1.41,0.82-2.48,2-3.16,3.37c-0.1-1.75,0.1-3.5,0.59-5.17C5.61,2.63,5.14,2,4.48,2 H4.47C4.04,2,3.64,2.28,3.52,2.7C2.24,7.01,2.65,11.81,5.07,16c1.1,1.91,2.88,3.19,4.86,3.72c1.98,0.53,4.16,0.31,6.07-0.79 c1.41-0.82,2.48-2,3.16-3.37c0.1,1.75-0.09,3.5-0.58,5.18C18.4,21.37,18.87,22,19.53,22h0c0.44,0,0.83-0.28,0.95-0.7 C21.75,16.99,21.35,12.19,18.93,8z M15,17.2c-2.87,1.65-6.54,0.67-8.2-2.2c-0.11-0.2-0.21-0.4-0.3-0.6C5.3,11.64,6.33,8.34,9,6.8 c2.86-1.65,6.54-0.67,8.2,2.2c0.11,0.2,0.21,0.4,0.3,0.6C18.7,12.36,17.67,15.66,15,17.2z M12,10c1.1,0,2,0.9,2,2s-0.9,2-2,2 s-2-0.9-2-2S10.9,10,12,10 M12,8c-2.21,0-4,1.79-4,4s1.79,4,4,4s4-1.79,4-4S14.21,8,12,8z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
