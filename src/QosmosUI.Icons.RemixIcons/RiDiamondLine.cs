// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiDiamondLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.4668 8.69379L19.7134 8.12811C20.1529 7.11947 20.9445 6.31641 21.9323 5.87708L22.6919 5.53922C23.1027 5.35653 23.1027 4.75881 22.6919 4.57612L21.9748 4.25714C20.9616 3.80651 20.1558 2.97373 19.7238 1.93083L19.4706 1.31953C19.2942 0.893489 18.7058 0.893489 18.5293 1.31953L18.2761 1.93083C17.8442 2.97373 17.0384 3.80651 16.0252 4.25714L15.3081 4.57612C14.8973 4.75881 14.8973 5.35653 15.3081 5.53922L16.0677 5.87708C17.0555 6.31641 17.8471 7.11947 18.2866 8.12811L18.5331 8.69379C18.7136 9.10792 19.2864 9.10792 19.4668 8.69379ZM5 6C4.68525 6 4.38886 6.14819 4.2 6.4L1.2 10.4C0.913337 10.7822 0.937093 11.3138 1.25671 11.669L10.2567 21.669C10.4464 21.8797 10.7165 22 11 22C11.2835 22 11.5537 21.8797 11.7433 21.669L20.7433 11.669L19.2567 10.331L11 19.5052L3.29335 10.9422L5.5 8H14V6H5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
