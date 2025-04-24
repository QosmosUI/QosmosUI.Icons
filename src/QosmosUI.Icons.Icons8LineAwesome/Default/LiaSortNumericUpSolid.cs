// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaSortNumericUpSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8.5898438 5 L 8.4394531 5.7792969 C 8.4394531 5.7792969 8.2708594 6.3594531 7.8808594 6.9394531 C 7.4808594 7.5194531 6.98 8 6 8 L 6 10 C 7.38 10 8.32 9.3198438 9 8.5898438 L 9 15 L 11 15 L 11 5 L 8.5898438 5 z M 23 5.5 L 22.279297 6.1894531 L 18 10.5 L 19.410156 11.910156 L 22 9.3105469 L 22 28 L 24 28 L 24 9.3105469 L 26.589844 11.910156 L 28 10.5 L 23.720703 6.1894531 L 23 5.5 z M 8.5 17 C 6.58 17 5 18.58 5 20.5 L 5 21 L 7 21 L 7 20.5 C 7 19.62 7.62 19 8.5 19 L 9.5 19 C 10.38 19 11 19.62 11 20.5 C 11 20.96 10.650547 21.479844 10.060547 21.839844 C 8.8305469 22.599844 7.7498437 23.089844 6.8398438 23.589844 C 6.3898437 23.849844 5.9791406 24.090703 5.6191406 24.470703 C 5.2691406 24.850703 5 25.42 5 26 L 5 27 L 13 27 L 13 25 L 8.4394531 25 C 9.1694531 24.62 10.019141 24.240547 11.119141 23.560547 C 12.139141 22.930547 13 21.84 13 20.5 C 13 18.58 11.42 17 9.5 17 L 8.5 17 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
