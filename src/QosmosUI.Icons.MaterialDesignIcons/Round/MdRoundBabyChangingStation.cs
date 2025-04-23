// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundBabyChangingStation : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M14,9L14,9c0,0.55-0.45,1-1,1h-1.58c-0.28,0-0.55-0.06-0.8-0.17l-2.3-1.01L7,12.75V21c0,0.55-0.45,1-1,1H4 c-0.55,0-1-0.45-1-1v-8.67c0-0.22,0.04-0.44,0.11-0.65l1.48-4.32C4.96,6.25,6.22,5.69,7.3,6.18l4.15,1.83L13,8 C13.55,8,14,8.45,14,9z M8,1C6.9,1,6,1.9,6,3s0.9,2,2,2s2-0.9,2-2S9.1,1,8,1z M10,19h10c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H10 c-0.55,0-1,0.45-1,1v0C9,18.55,9.45,19,10,19z M19.5,16c0.83,0,1.5-0.67,1.5-1.5c0-0.83-0.67-1.5-1.5-1.5S18,13.67,18,14.5 C18,15.33,18.67,16,19.5,16z M13,12c0-0.55-0.45-1-1-1h-2c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h1v1c0,1.1,0.9,2,2,2h2 c1.1,0,2-0.9,2-2v-2c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v1h-2V12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
