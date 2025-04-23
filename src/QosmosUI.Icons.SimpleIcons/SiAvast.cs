// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAvast : ComponentBase
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
		builder.AddAttribute(15, "d", "M10.2941 2.991a3.0286 3.0286 0 0 1 4.4499 1.2039l7.0018 14.8042a11.937 11.937 0 0 0 2.2539-6.9131C24.0464 5.4569 18.7112.047 12.0834.0004 5.4556-.0463.047 5.2889.0004 11.9167a11.9356 11.9356 0 0 0 2.2213 7.0344l.2813-.0613 4.5692-1.008c.1287-.0286.1967.1454.084.2127L3.3736 20.337a11.9563 11.9563 0 0 0 8.5431 3.6625c3.76.0267 7.1258-1.68 9.3444-4.3705L9.8095 7.5735a3.0272 3.0272 0 0 1 .4846-4.5826zm2.1493 13.6089-7.3731.64a1.302 1.302 0 1 1 .1866-2.5666l7.2031 1.6972c.1287.0314.114.2174-.0166.2294zM9.03 10.116l8.9404 7.2324c.102.0827.01.2447-.1133.198L7.1035 13.4713a1.9593 1.9593 0 1 1 1.9266-3.3552z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
