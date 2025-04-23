// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Heroicons.Mini;

public class HiMiniScissors : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 20 20";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M1.469 3.75a3.5 3.5 0 0 0 5.617 4.11l.883.51c.025.092.147.116.21.043.15-.176.318-.338.5-.484.286-.23.3-.709-.018-.892l-.825-.477A3.501 3.501 0 0 0 1.47 3.75Zm2.03 3.482a2 2 0 1 1 2-3.464 2 2 0 0 1-2 3.464ZM9.956 8.322a2.75 2.75 0 0 0-1.588 1.822L7.97 11.63l-.884.51A3.501 3.501 0 0 0 1.47 16.25a3.5 3.5 0 0 0 6.367-2.81l10.68-6.166a.75.75 0 0 0-.182-1.373l-.703-.189a2.75 2.75 0 0 0-1.78.123L9.955 8.322ZM2.768 15.5a2 2 0 1 1 3.464-2 2 2 0 0 1-3.464 2Z");
		builder.AddAttribute(16, "clip-rule", "evenodd");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M12.52 11.89a.5.5 0 0 0 .056.894l3.274 1.381a2.75 2.75 0 0 0 1.78.123l.704-.189a.75.75 0 0 0 .18-1.373l-3.47-2.004a.5.5 0 0 0-.5 0L12.52 11.89Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
