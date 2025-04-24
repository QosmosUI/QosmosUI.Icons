// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaSimplybuilt : ComponentBase
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
		builder.AddAttribute(14, "d", "M 6 7 C 4.90625 7 4 7.90625 4 9 L 4 23 C 4 24.09375 4.90625 25 6 25 L 26 25 C 27.09375 25 28 24.09375 28 23 L 28 9 C 28 7.90625 27.09375 7 26 7 L 22 7 C 20.90625 7 20 7.90625 20 9 L 20 10 L 12 10 L 12 9 C 12 7.90625 11.09375 7 10 7 Z M 6 9 L 10 9 L 10 12 L 22 12 L 22 9 L 26 9 L 26 23 L 6 23 Z M 12 14.5 C 10.34375 14.5 9 15.84375 9 17.5 C 9 19.15625 10.34375 20.5 12 20.5 C 13.65625 20.5 15 19.15625 15 17.5 C 15 15.84375 13.65625 14.5 12 14.5 Z M 20 14.5 C 18.34375 14.5 17 15.84375 17 17.5 C 17 19.15625 18.34375 20.5 20 20.5 C 21.65625 20.5 23 19.15625 23 17.5 C 23 15.84375 21.65625 14.5 20 14.5 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
