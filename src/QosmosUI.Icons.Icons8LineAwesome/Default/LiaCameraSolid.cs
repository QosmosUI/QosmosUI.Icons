// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaCameraSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 11.5 6 L 11.1875 6.40625 L 10 8 L 3 8 L 3 26 L 29 26 L 29 8 L 22 8 L 20.8125 6.40625 L 20.5 6 Z M 12.5 8 L 19.5 8 L 20.6875 9.59375 L 21 10 L 27 10 L 27 24 L 5 24 L 5 10 L 11 10 L 11.3125 9.59375 Z M 8 11 C 7.449219 11 7 11.449219 7 12 C 7 12.550781 7.449219 13 8 13 C 8.550781 13 9 12.550781 9 12 C 9 11.449219 8.550781 11 8 11 Z M 16 11 C 12.699219 11 10 13.699219 10 17 C 10 20.300781 12.699219 23 16 23 C 19.300781 23 22 20.300781 22 17 C 22 13.699219 19.300781 11 16 11 Z M 16 13 C 18.222656 13 20 14.777344 20 17 C 20 19.222656 18.222656 21 16 21 C 13.777344 21 12 19.222656 12 17 C 12 14.777344 13.777344 13 16 13 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
