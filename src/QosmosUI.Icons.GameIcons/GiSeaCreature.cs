// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSeaCreature : ComponentBase
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
		builder.AddAttribute(14, "d", "M421.064 120.467c-8.182-.15-16.182 1.82-24.797 5.484-16.37 7-29 34.22-36.61 56.13-12.188 41.125-18.54 174.724-38.79 209.46h71.64c2.74-26.73 2.38-147.44 3.93-171.83.93-14.65 7.38-37.13 17.05-41.24 6.21-2.64 14.69-4.3 38 13.78 8.17 6.29 61.02-13.88 23.94-44.76-22.463-18.716-38.743-26.735-54.363-27.023zm20.006 18.027a9 9 0 1 1 0 18 9 9 0 0 1 0-18zM216.047 321.12c-55 0-77 69.35-77 69.35.013.335.043.67.09 1h148.61c.04-.31.08-.66.08-1 0-5.82-24.25-69.35-71.78-69.35zm-153.03 29.322c-21.82 0-39.5 41.068-39.5 41.068h79c.04-4.76-17.65-41.068-39.5-41.068z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
