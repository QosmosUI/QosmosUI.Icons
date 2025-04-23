// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaListAlt : ComponentBase
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
		builder.AddAttribute(14, "d", "M 10.28125 5.28125 L 7 8.5625 L 5.71875 7.28125 L 4.28125 8.71875 L 6.28125 10.71875 L 7 11.40625 L 7.71875 10.71875 L 11.71875 6.71875 Z M 15 7 L 15 9 L 28 9 L 28 7 Z M 10.28125 13.28125 L 7 16.5625 L 5.71875 15.28125 L 4.28125 16.71875 L 6.28125 18.71875 L 7 19.40625 L 7.71875 18.71875 L 11.71875 14.71875 Z M 15 15 L 15 17 L 28 17 L 28 15 Z M 10.28125 21.28125 L 7 24.5625 L 5.71875 23.28125 L 4.28125 24.71875 L 6.28125 26.71875 L 7 27.40625 L 7.71875 26.71875 L 11.71875 22.71875 Z M 15 23 L 15 25 L 28 25 L 28 23 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
