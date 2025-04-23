// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaObjectUngroupSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 9 L 6 9 L 6 19 L 5 19 L 5 23 L 9 23 L 9 22 L 11 22 L 11 24 L 10 24 L 10 28 L 14 28 L 14 27 L 24 27 L 24 28 L 28 28 L 28 24 L 27 24 L 27 14 L 28 14 L 28 10 L 24 10 L 24 11 L 22 11 L 22 9 L 23 9 L 23 5 L 19 5 L 19 6 L 9 6 L 9 5 Z M 9 8 L 19 8 L 19 9 L 20 9 L 20 19 L 19 19 L 19 20 L 9 20 L 9 19 L 8 19 L 8 9 L 9 9 Z M 22 13 L 24 13 L 24 14 L 25 14 L 25 24 L 24 24 L 24 25 L 14 25 L 14 24 L 13 24 L 13 22 L 19 22 L 19 23 L 23 23 L 23 19 L 22 19 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
