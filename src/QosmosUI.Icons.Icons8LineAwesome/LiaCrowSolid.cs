// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaCrowSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 7 6 C 4.791 6 3 7.791 3 10 L 3 15 C 3 19.078645 6.0548764 22.438586 10 22.931641 L 10 27 L 12 27 L 12 23 L 13 23 L 14 23 L 14 27 L 16 27 L 16 23 L 22.384766 23 L 25.462891 25 L 29.462891 25 L 11 13 L 11 10 L 15 10 C 15 8.343 12.796 7 11 7 L 9.6191406 7 C 8.9159072 6.385563 8.0071175 6 7 6 z M 7 8 C 7.2018241 8 7.392375 8.0398719 7.5761719 8.0957031 A 1 1 0 0 0 8 10 A 1 1 0 0 0 8.9042969 9.4238281 C 8.9601281 9.607625 9 9.7981759 9 10 L 9 13 L 9 14.085938 L 9.9101562 14.675781 L 19.638672 21 L 13 21 L 11 21 C 7.692 21 5 18.308 5 15 L 5 10 C 5 8.897 5.897 8 7 8 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
