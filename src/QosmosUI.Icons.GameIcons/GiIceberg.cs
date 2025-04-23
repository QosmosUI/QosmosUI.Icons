// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiIceberg : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M304.28 29.19l-12.523 80.56 8.06 55.25h165.347l-8.61-97.642-35.503 19.42 5.786 51.58L411.94 83.1l-38.042-40.565zM121 43.144v84.408h28.246c-5.08-29.13-12.29-58.546-28.246-84.407zm135.28 58.695l-16 61.808-.243 1.354h53.313l-12.674-45.357zM61.362 145.55l8.7 21.45h85.648l17.4-21.45zM18 183v18h476v-18zm212.39 36l-6.11 34.19 7.308 39.683-39.31 64.613 16 71.705 32-16 14.656-22.713 3.584-13.707-7.264-53.698 24.447 49.52-3.528 51.95 16.107 36.65L336 489.68l19.69-31.145 4.47-41.22 13.32 54.576 37.813-9.452-6.934-167.79 14.988 99.475 28.93-28.932 23.507-144-.258-2.19h-73.912l1.44 6.71-23.49 101.577 7.693-96.355L372.252 219zm50.807 10.096l23.34 17.877 4.967 17.382-9.436 44.2-5.463-49.662z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
