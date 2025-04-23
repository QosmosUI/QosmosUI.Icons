// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAirplanemodeActive : ComponentBase
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
		builder.AddAttribute(15, "d", "M21.48,13.7L13.5,9V3.5C13.5,2.67,12.83,2,12,2c-0.83,0-1.5,0.67-1.5,1.5V9l-7.98,4.7C2.2,13.88,2,14.23,2,14.6 c0,0.7,0.67,1.2,1.34,1.01l7.16-2.1V19l-2.26,1.35C8.09,20.44,8,20.61,8,20.78l0,0.5h0v0.08c0,0.33,0.31,0.57,0.62,0.49l2.92-0.73 L12,21l0.38,0.09c0,0,0,0,0,0l0.42,0.11l1.9,0.48l0,0l0.67,0.17c0.32,0.08,0.62-0.16,0.62-0.49v-0.37c0,0,0,0,0,0v-0.21 c0-0.18-0.09-0.34-0.24-0.43L13.5,19v-5.5l7.16,2.1C21.33,15.8,22,15.3,22,14.6C22,14.23,21.8,13.88,21.48,13.7z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(18, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
