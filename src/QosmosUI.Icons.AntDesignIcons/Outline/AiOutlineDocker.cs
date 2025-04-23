// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.AntDesignIcons.Outline;

public class AiOutlineDocker : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 1024 1024";

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
		builder.AddAttribute(14, "d", "M491.877 286.236h-92.612v-82.784h92.612zm0-286.236h-92.612v85.59h92.612zm109.45 203.452h-92.612v82.784h92.612zm-218.9-101.024h-92.612v84.187h92.612zm109.45 0h-92.612v84.187h92.612zm388.688 140.311c-19.645-14.03-67.354-18.24-102.434-11.225-4.21-33.674-23.855-63.14-57.532-89.8l-19.645-12.627-12.628 19.644c-25.258 39.287-32.274 103.83-5.613 145.924-12.63 7.015-36.484 15.434-67.354 15.434H3.56c-12.629 71.56 8.42 164.165 61.741 227.305C117.221 599.131 195.8 630 296.832 630c220.302 0 384.478-101.024 460.25-286.236 29.468 0 95.419 0 127.692-63.14 1.404-2.807 9.823-18.24 11.226-23.853zm-717.038-39.287H70.915v82.784h92.612zm109.45 0h-92.612v82.784h92.612zm109.45 0h-92.612v82.784h92.612zm-109.45-101.024h-92.612v84.187h92.612z");
		builder.AddAttribute(15, "transform", "translate(64 202)");
		builder.CloseElement();
		builder.CloseElement();
    }
}
