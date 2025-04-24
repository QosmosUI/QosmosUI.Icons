// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDatev : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 .165v16.9174h23.9147V.1651Zm.017 18.1842v5.4857h1.9809c1.4754 0 2.7429-1.1832 2.7429-2.7005-.042-1.686-1.0982-2.7852-2.5736-2.7852zm6.62 0-2.1079 5.4857H5.706l1.6422-4.3428 1.3546 3.454h-1.524v.8888h3.0392l-2.1502-5.4857Zm2.6498 0v.9312h1.7778v4.5545h1.219v-4.5545h1.727v-.9312zm5.1894 0v5.4857h3.7926v-.8889h-2.6159v-1.5153h2.3196v-.9313h-2.3196v-1.219h2.4889v-.9312zm3.962 0 2.1502 5.4857h1.3037L24 18.3492h-2.9037v.9312h1.3884l-1.2699 3.327-1.5577-4.2582zm-17.2869.9312h.9313c.9271 0 1.5576.6735 1.5153 1.8117-.042 1.1804-.8425 1.8116-1.8116 1.8116h-.635Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
