// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFrayedArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.795 22.313v146.882c55.798 46.488 119.15 83.37 184.63 117.045-68.898-9.21-127.42-27.277-176.08-56.648 25.434 36.314 76.9 75.687 123.05 93.105 5.342-.26 10.686-.385 16.035-.36 59.215.29 118.975 18.028 182.593 51.007-73.04-10.31-146.083-16.405-219.125-9.024l-31.84 8.106c137.858 15.975 273.397 44.77 399.2 127.383L330.693 117.4c4.486 88.07 27.066 170.91 59.79 252.354C310.604 277.09 276.607 167.96 273.126 63.37c-9.615 54.178-6.77 117.06 5.514 180.732-42.698-79.1-60.54-156.684-54.908-221.79H118.29c20.587 101.514 94.966 212.595 191.64 303.282C177.518 247.214 109.7 132.916 64.518 22.313H20.795z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
