// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaCocktailSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8.5 4 C 5.464844 4 3 6.464844 3 9.5 C 3 12.535156 5.464844 15 8.5 15 C 9.3125 15 10.078125 14.796875 10.78125 14.46875 L 16 21.34375 L 16 27 L 12 27 L 12 29 L 22 29 L 22 27 L 18 27 L 18 21.34375 L 26.8125 9.71875 L 27 9.4375 L 27 8 L 13.75 8 C 13.144531 5.679688 10.984375 4 8.5 4 Z M 8.5 6 C 9.890625 6 11.089844 6.839844 11.625 8 L 7 8 L 7 9.4375 L 7.1875 9.71875 L 9.53125 12.8125 C 9.1875 12.933594 8.835938 13 8.5 13 C 6.535156 13 5 11.464844 5 9.5 C 5 7.535156 6.535156 6 8.5 6 Z M 9.9375 10 L 24.0625 10 L 22.5625 12 L 13.5 12 L 15 14 L 21.03125 14 L 17 19.34375 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
