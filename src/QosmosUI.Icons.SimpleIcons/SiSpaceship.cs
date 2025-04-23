// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiSpaceship : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.9997 1.2529c1.0445 0 1.956.5689 2.441 1.4125l4.5883 7.9314 4.45 7.6915c.0466.074.2105.3585.27.4938.2216.4677.2505.9472.251 1.1595 0 1.5496-1.2587 2.8056-2.8116 2.8056-.2949 0-.579-.045-.8457-.129l-7.9011-2.6061a1.406 1.406 0 0 0-.4413-.0705 1.413 1.413 0 0 0-.442.0705L3.658 22.6183l-.1623.0456a2.8398 2.8398 0 0 1-.6838.0831c-1.5531 0-2.8119-1.256-2.8119-2.8056.002-.243.0234-.5533.168-.9578.0294-.0911.0743-.176.1115-.264.0712-.1487.1607-.2875.2411-.4313l4.4493-7.6916 4.5883-7.9313c.485-.8437 1.3971-1.4126 2.4416-1.4126z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
