// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBackHand : ComponentBase
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
		builder.AddAttribute(18, "d", "M19,16c0,3.31-2.69,6-6,6h0c-2.61,0-4.95-1.59-5.91-4.01l-2.6-6.54l0.53,0.14c0.46,0.12,0.83,0.46,1,0.9L7,15 h2V4.5C9,4.22,9.22,4,9.5,4S10,4.22,10,4.5V12h2V2.5C12,2.22,12.22,2,12.5,2S13,2.22,13,2.5V12h2V4c0-0.28,0.22-0.5,0.5-0.5 S16,3.72,16,4v8h2V7c0-0.28,0.22-0.5,0.5-0.5S19,6.72,19,7L19,16z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M21,7c0-1.38-1.12-2.5-2.5-2.5c-0.17,0-0.34,0.02-0.5,0.05V4c0-1.38-1.12-2.5-2.5-2.5c-0.23,0-0.46,0.03-0.67,0.09 C14.46,0.66,13.56,0,12.5,0c-1.23,0-2.25,0.89-2.46,2.06C9.87,2.02,9.69,2,9.5,2C8.12,2,7,3.12,7,4.5v5.89 c-0.34-0.31-0.76-0.54-1.22-0.66L5.01,9.52c-0.83-0.23-1.7,0.09-2.19,0.83c-0.38,0.57-0.4,1.31-0.15,1.95l2.56,6.43 C6.49,21.91,9.57,24,13,24h0c4.42,0,8-3.58,8-8V7z M19,16c0,3.31-2.69,6-6,6h0c-2.61,0-4.95-1.59-5.91-4.01l-2.6-6.54l0.53,0.14 c0.46,0.12,0.83,0.46,1,0.9L7,15h2V4.5C9,4.22,9.22,4,9.5,4S10,4.22,10,4.5V12h2V2.5C12,2.22,12.22,2,12.5,2S13,2.22,13,2.5V12h2V4 c0-0.28,0.22-0.5,0.5-0.5S16,3.72,16,4v8h2V7c0-0.28,0.22-0.5,0.5-0.5S19,6.72,19,7L19,16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
