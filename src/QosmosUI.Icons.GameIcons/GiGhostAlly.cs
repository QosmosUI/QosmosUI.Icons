// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiGhostAlly : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M216.242 23.555c-1.514-.042-3.074.125-4.588.125-32.333 0-58.656 33.378-58.656 74.736 0 20.942 6.97 39.84 17.813 53.44-67.073 10.403-65.61 115.718-65.61 188.576h40.41l9.992 151.642h78.41l-9.496-151.35h-40.58c0-72.856-1.285-178.355 65.79-188.755-10.842-13.602-17.83-32.55-17.83-53.49 0-22.137 7.473-41.88 19.374-55.46-9.035-10.623-20.667-17.67-33.532-19.34-.492-.075-.99-.11-1.496-.125zm78.703.402c-1.533-.04-3.126.125-4.64.125V492.59h52.26l11.683-151.865h42.422c0-72.654-5-175.973-66.402-187.526 11.328-13.665 19.06-33.248 19.06-54.72 0-38.777-23.35-70.56-52.875-74.398-.492-.074-.997-.11-1.508-.125z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
