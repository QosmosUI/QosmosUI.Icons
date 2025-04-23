// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiArmorDowngrade : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 21.95l-5.4 4.03C187.5 73.41 125.4 104.5 30.58 120.3l-7.5 1.2v7.6c0 19 8.4 48.7 22.1 85.1 13.6 36.5 32.8 78.8 55.02 119.2 22.3 40.4 47.4 78.9 73.8 107.7 26.1 28.9 53.5 48.9 82 48.9s55.9-20 82.2-48.9c26.2-28.8 51.3-67.3 73.7-107.7 22.2-40.4 41.3-82.7 55-119.2 13.6-36.4 22-66.1 22-85.1v-7.6l-7.4-1.2c-94.6-15.8-156.9-46.89-220.1-94.32zm0 22.2c61.1 45.04 124.4 76.15 214.4 92.35-1.9 15.2-9 41.4-20.3 71.5-4.1 10.8-8.6 22.2-13.7 34H288v46l64-16-96 112-96-112 64 16v-46H75.57c-5-11.8-9.59-23.2-13.69-34-11.2-30.1-18.4-56.3-20.3-71.5C131.6 120.3 194.8 89.19 256 44.15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
