// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundElderly : ComponentBase
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
		builder.AddAttribute(18, "d", "M11.5,3.5c0-1.1,0.9-2,2-2s2,0.9,2,2c0,1.1-0.9,2-2,2S11.5,4.6,11.5,3.5z M18.53,11c-1.57,0.01-2.94-0.9-3.6-2.21 l-0.79-1.67l0,0c-0.17-0.35-0.44-0.65-0.8-0.85c-0.62-0.36-1.35-0.34-1.94-0.03l0-0.01L7.01,8.73C6.39,9.08,6,9.74,6,10.46V13 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-2.54l1.5-0.85C9.18,10.71,9,11.85,9,13v5.33L7,21c-0.33,0.44-0.24,1.07,0.2,1.4 c0.44,0.33,1.07,0.24,1.4-0.2l2.04-2.72c0.23-0.31,0.37-0.69,0.4-1.08l0.18-2.94L13,18v4c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1 v-4.87c0-0.41-0.13-0.81-0.36-1.15l-1.6-2.29c0,0,0,0,0-0.01c-0.11-1.16,0.07-2.32,0.46-3.4c0.81,1.23,2.05,2.14,3.51,2.52v0.03V13 c0,0.28,0.22,0.5,0.5,0.5S18,13.28,18,13v-0.16V12.5c0-0.28,0.22-0.5,0.5-0.5s0.5,0.22,0.5,0.5v10c0,0.28,0.22,0.5,0.5,0.5 s0.5-0.22,0.5-0.5v-10C20,11.68,19.34,10.99,18.53,11z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
