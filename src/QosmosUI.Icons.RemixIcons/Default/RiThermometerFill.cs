// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiThermometerFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.5565 3.44367C22.1186 5.00576 22.1186 7.53842 20.5565 9.10052L12.3563 17.3008C11.714 17.943 10.8723 18.3476 9.96957 18.4479L6.59094 18.8221L4.29304 21.1213C3.90252 21.5119 3.26936 21.5119 2.87883 21.1213C2.48831 20.7308 2.48831 20.0976 2.87883 19.7071L5.17694 17.4081L5.55231 14.0306C5.65261 13.1279 6.05716 12.2862 6.69942 11.6439L14.8996 3.44367C16.4617 1.88157 18.9944 1.88157 20.5565 3.44367ZM11.3641 12.6361L9.9499 14.0503L12.0712 16.1716L13.4854 14.7574L11.3641 12.6361ZM14.1925 9.80763L12.7783 11.2218L14.8996 13.3432L16.3139 11.9289L14.1925 9.80763ZM17.021 6.9792L15.6068 8.39341L17.7281 10.5147L19.1423 9.10052L17.021 6.9792Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
