// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaDhl : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 640 512";

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
		builder.AddAttribute(14, "d", "M238 301.2h58.7L319 271h-58.7L238 301.2zM0 282.9v6.4h81.8l4.7-6.4H0zM172.9 271c-8.7 0-6-3.6-4.6-5.5 2.8-3.8 7.6-10.4 10.4-14.1 2.8-3.7 2.8-5.9-2.8-5.9h-51l-41.1 55.8h100.1c33.1 0 51.5-22.5 57.2-30.3h-68.2zm317.5-6.9l39.3-53.4h-62.2l-39.3 53.4h62.2zM95.3 271H0v6.4h90.6l4.7-6.4zm111-26.6c-2.8 3.8-7.5 10.4-10.3 14.2-1.4 2-4.1 5.5 4.6 5.5h45.6s7.3-10 13.5-18.4c8.4-11.4.7-35-29.2-35H112.6l-20.4 27.8h111.4c5.6 0 5.5 2.2 2.7 5.9zM0 301.2h73.1l4.7-6.4H0v6.4zm323 0h58.7L404 271h-58.7c-.1 0-22.3 30.2-22.3 30.2zm222 .1h95v-6.4h-90.3l-4.7 6.4zm22.3-30.3l-4.7 6.4H640V271h-72.7zm-13.5 18.3H640v-6.4h-81.5l-4.7 6.4zm-164.2-78.6l-22.5 30.6h-26.2l22.5-30.6h-58.7l-39.3 53.4H409l39.3-53.4h-58.7zm33.5 60.3s-4.3 5.9-6.4 8.7c-7.4 10-.9 21.6 23.2 21.6h94.3l22.3-30.3H423.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
