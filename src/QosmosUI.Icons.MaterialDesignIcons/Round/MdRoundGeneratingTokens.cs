// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundGeneratingTokens : ComponentBase
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
		builder.AddAttribute(18, "d", "M9,4c-4.42,0-8,3.58-8,8c0,4.42,3.58,8,8,8s8-3.58,8-8C17,7.58,13.42,4,9,4z M9,15.5c-0.55,0-1-0.45-1-1v-4H6.75 C6.34,10.5,6,10.16,6,9.75S6.34,9,6.75,9h4.5C11.66,9,12,9.34,12,9.75s-0.34,0.75-0.75,0.75H10v4C10,15.05,9.55,15.5,9,15.5z M20.25,3.75L22,4.54c0.39,0.18,0.39,0.73,0,0.91l-1.75,0.79L19.46,8c-0.18,0.39-0.73,0.39-0.91,0l-0.79-1.75L16,5.46 c-0.39-0.18-0.39-0.73,0-0.91l1.75-0.79L18.54,2c0.18-0.39,0.73-0.39,0.91,0L20.25,3.75z M20.25,17.75L22,18.54 c0.39,0.18,0.39,0.73,0,0.91l-1.75,0.79L19.46,22c-0.18,0.39-0.73,0.39-0.91,0l-0.79-1.75L16,19.46c-0.39-0.18-0.39-0.73,0-0.91 l1.75-0.79L18.54,16c0.18-0.39,0.73-0.39,0.91,0L20.25,17.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
