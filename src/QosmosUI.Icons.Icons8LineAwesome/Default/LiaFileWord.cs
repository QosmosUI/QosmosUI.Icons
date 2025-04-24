// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaFileWord : ComponentBase
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
		builder.AddAttribute(14, "d", "M 6 3 L 6 29 L 26 29 L 26 3 Z M 8 5 L 24 5 L 24 27 L 8 27 Z M 18 12 L 18 18.5 C 18 18.714844 17.714844 19 17.5 19 C 17.457031 19 17.519531 19.046875 17.4375 18.9375 C 17.355469 18.828125 17.230469 18.550781 17.15625 18.25 C 17.007813 17.652344 17 17 17 17 L 17 15 L 15 15 L 15 19.5 C 15 19.714844 14.714844 20 14.5 20 C 14.285156 20 14 19.714844 14 19.5 L 14 13 L 10 13 L 10 15 L 12 15 L 12 19.5 C 12 20.882813 13.117188 22 14.5 22 C 15.484375 22 16.1875 21.355469 16.59375 20.53125 C 16.894531 20.71875 17.113281 21 17.5 21 C 18.882813 21 20 19.882813 20 18.5 L 20 14 L 22 14 L 22 12 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
