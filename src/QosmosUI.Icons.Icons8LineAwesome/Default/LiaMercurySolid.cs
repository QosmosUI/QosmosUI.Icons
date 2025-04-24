// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaMercurySolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 11 2 C 11 3.476563 11.660156 4.800781 12.6875 5.71875 C 9.929688 6.984375 8 9.777344 8 13 C 8 17.066406 11.066406 20.4375 15 20.9375 L 15 24 L 11 24 L 11 26 L 15 26 L 15 30 L 17 30 L 17 26 L 21 26 L 21 24 L 17 24 L 17 20.9375 C 20.933594 20.4375 24 17.066406 24 13 C 24 9.777344 22.070313 6.984375 19.3125 5.71875 C 20.339844 4.800781 21 3.476563 21 2 L 19 2 C 19 3.667969 17.667969 5 16 5 C 14.332031 5 13 3.667969 13 2 Z M 16 7 C 19.324219 7 22 9.675781 22 13 C 22 16.324219 19.324219 19 16 19 C 12.675781 19 10 16.324219 10 13 C 10 9.675781 12.675781 7 16 7 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
