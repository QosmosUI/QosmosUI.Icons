// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPaintedPottery : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M240 24c-16 0-48 16-64 32 0 13 0 26 8.582 39h142.836C336 82 336 69 336 56c-16-16-48-32-64-32zm-44.072 89c10.008 26.313 10.699 59.404 2.084 78h115.976c-8.615-18.596-7.924-51.687 2.084-78zm-16.471 96c-36.902 28.393-62.07 65.607-66.684 94h286.454c-4.614-28.393-29.782-65.607-66.684-94zm-66.908 112c5.395 44.88 49.453 88 79.451 103 8.465 8.465 12.43 16.904 14.307 23h99.386c1.878-6.096 5.842-14.535 14.307-23 29.998-15 74.056-58.12 79.451-103zm84.105 144c-11.436 6.993-20.654 7-20.654 7-16 0-16 16 0 16h160c16 0 16-16 0-16 0 0-9.218-.007-20.654-7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
