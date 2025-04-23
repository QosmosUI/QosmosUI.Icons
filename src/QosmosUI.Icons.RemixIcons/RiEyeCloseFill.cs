// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiEyeCloseFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M10.1305 15.8421L9.34268 18.7821L7.41083 18.2645L8.1983 15.3256C7.00919 14.8876 5.91661 14.2501 4.96116 13.4536L2.80783 15.6069L1.39362 14.1927L3.54695 12.0394C2.35581 10.6105 1.52014 8.8749 1.17578 6.96843L2.07634 6.80469C4.86882 8.81573 8.29618 10.0003 12.0002 10.0003C15.7043 10.0003 19.1316 8.81573 21.9241 6.80469L22.8247 6.96843C22.4803 8.8749 21.6446 10.6105 20.4535 12.0394L22.6068 14.1927L21.1926 15.6069L19.0393 13.4536C18.0838 14.2501 16.9912 14.8876 15.8021 15.3256L16.5896 18.2645L14.6578 18.7821L13.87 15.8421C13.2623 15.9461 12.6376 16.0003 12.0002 16.0003C11.3629 16.0003 10.7381 15.9461 10.1305 15.8421Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
