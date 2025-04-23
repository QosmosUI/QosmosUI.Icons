// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiLifebuoyFill : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M12 2C17.5228 2 22 6.47715 22 12C22 17.5228 17.5228 22 12 22C6.47715 22 2 17.5228 2 12C2 6.47715 6.47715 2 12 2ZM7.19709 14.682L5.02243 16.8555C5.52665 17.5788 6.14045 18.2199 6.83975 18.7549L7.14462 18.9777L9.31803 16.8029C8.51078 16.3512 7.82909 15.7018 7.33848 14.9203L7.19709 14.682ZM16.8029 14.682C16.3512 15.4892 15.7018 16.1709 14.9203 16.6615L14.682 16.8029L16.8555 18.9776C17.5787 18.4734 18.2198 17.8596 18.7549 17.1604L18.9776 16.8555L16.8029 14.682ZM12 8C9.79086 8 8 9.79086 8 12C8 14.2091 9.79086 16 12 16C14.2091 16 16 14.2091 16 12C16 9.79086 14.2091 8 12 8ZM7.14462 5.02232C6.42133 5.52656 5.78012 6.14039 5.24506 6.83973L5.02232 7.14462L7.19709 9.31803C7.64883 8.51078 8.2982 7.82909 9.07969 7.33848L9.31803 7.19709L7.14462 5.02232ZM16.8555 5.02243L14.682 7.19709C15.4892 7.64883 16.1709 8.2982 16.6615 9.07969L16.8029 9.31803L18.9777 7.14462C18.4735 6.42137 17.8597 5.7802 17.1604 5.24516L16.8555 5.02243Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
