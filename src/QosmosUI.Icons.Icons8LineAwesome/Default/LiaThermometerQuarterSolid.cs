// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaThermometerQuarterSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 12 4 L 12 15.5 C 10.2 16.8 9 18.7 9 21 C 9 24.9 12.1 28 16 28 C 19.9 28 23 24.9 23 21 C 23 18.7 21.8 16.7 20 15.5 L 20 14 L 22 14 L 22 12 L 20 12 L 20 10 L 22 10 L 22 8 L 20 8 L 20 6 L 22 6 L 22 4 L 12 4 z M 14 6 L 18 6 L 18 16.400391 L 18.5 16.699219 C 20 17.499219 21 19.2 21 21 C 21 23.8 18.8 26 16 26 C 13.2 26 11 23.8 11 21 C 11 19.2 12 17.499219 13.5 16.699219 L 14 16.400391 L 14 6 z M 13.800781 19 C 13.300781 19.5 13 20.2 13 21 C 13 22.7 14.3 24 16 24 C 17.7 24 19 22.7 19 21 C 19 20.2 18.699219 19.5 18.199219 19 L 13.800781 19 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
