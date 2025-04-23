// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiTaichilang : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M15.526 4.6782c-.0196 1.6052-.8167 2.8963-2.211 3.8542-1.2176.8371-2.47 1.627-3.6316 2.5398-1.8976 1.4954-3.1392 3.4337-3.1784 5.9263-.0415 2.7115 1.1753 4.7975 3.4344 6.274.0415.0276.0888.0502.1302.0756.2.123.3637.3055.2197.5237-.0698.1033-.3273.1542-.4728.115-1.2168-.2975-2.3856-.731-3.4556-1.395-3.462-2.1486-5.484-5.2623-5.9517-9.318C-.2542 7.4683 3.1934 2.0903 8.6833.3542c1.3558-.4313 2.7224-.5266 4.0731.0422 1.7223.72 2.8257 2.3806 2.7697 4.2818Zm8.1462 9.2648c-.0276 1.0699-.328 2.2693-1.4445 3.1115-1.3004.9805-2.9755.9165-3.9981-.1483a2.8359 2.8359 0 0 1-.6444-1.0809 2.9144 2.9144 0 0 1-.12-1.2546 2.8788 2.8788 0 0 1 .4334-1.1856 2.8439 2.8439 0 0 1 .8976-.8786c.1389-.0873.2807-.171.4218-.2524 1.1674-.6582 1.6925-1.6889 1.731-3.0053a1.9547 1.9547 0 0 1 .0895-.3804c.131.056.28.0836.3884.1709 1.4336 1.126 2.2453 2.8148 2.2453 4.9037z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
