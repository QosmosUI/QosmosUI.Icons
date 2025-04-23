// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaStarOfLifeSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 13 4 L 13 10.804688 L 7.1074219 7.4023438 L 4.1074219 12.599609 L 10 16 L 4.1074219 19.400391 L 7.1074219 24.597656 L 13 21.195312 L 13 28 L 19 28 L 19 21.195312 L 24.892578 24.597656 L 27.892578 19.400391 L 22 16 L 27.892578 12.599609 L 24.892578 7.4023438 L 19 10.804688 L 19 4 L 13 4 z M 15 6 L 17 6 L 17 14.269531 L 24.160156 10.134766 L 25.160156 11.865234 L 18 16 L 25.160156 20.134766 L 24.160156 21.865234 L 17 17.730469 L 17 26 L 15 26 L 15 17.730469 L 7.8398438 21.865234 L 6.8398438 20.134766 L 14 16 L 6.8398438 11.865234 L 7.8398438 10.134766 L 15 14.269531 L 15 6 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
