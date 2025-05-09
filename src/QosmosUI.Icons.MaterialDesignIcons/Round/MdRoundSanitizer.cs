// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSanitizer : ComponentBase
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
		builder.AddAttribute(18, "d", "M15.5,6.5c0-0.56,0.67-1.49,1.11-2.04c0.2-0.25,0.58-0.25,0.77,0c0.44,0.55,1.11,1.48,1.11,2.04C18.5,7.33,17.83,8,17,8 S15.5,7.33,15.5,6.5z M19.5,15c1.38,0,2.5-1.12,2.5-2.5c0-1.25-1.41-3.16-2.11-4.04c-0.2-0.25-0.57-0.25-0.77,0 C18.41,9.34,17,11.25,17,12.5C17,13.88,18.12,15,19.5,15z M12,14h-1v-1c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v1H8 c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h1v1c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-1h1c0.55,0,1-0.45,1-1v0 C13,14.45,12.55,14,12,14z M16,12v8c0,1.1-0.9,2-2,2H6c-1.1,0-2-0.9-2-2v-8c0-2.97,2.16-5.43,5-5.91V4H8C7.45,4,7,3.55,7,3v0 c0-0.55,0.45-1,1-1h5c0.61,0,1.19,0.11,1.72,0.31c0.67,0.25,0.83,1.13,0.33,1.64l0,0C14.77,4.23,14.36,4.31,14,4.18 C13.68,4.06,13.35,4,13,4h-2v2.09C13.84,6.57,16,9.03,16,12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
