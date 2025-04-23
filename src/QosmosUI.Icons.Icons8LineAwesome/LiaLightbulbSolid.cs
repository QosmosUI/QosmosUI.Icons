// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaLightbulbSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 C 11.042969 4 7 8.042969 7 13 C 7 14.917969 7.84375 16.90625 9 18.6875 C 9.859375 20.011719 10.886719 21.230469 12 22.15625 L 12 25 C 12 26.09375 12.90625 27 14 27 L 15 28 L 17 28 L 18 27 C 19.09375 27 20 26.09375 20 25 L 20 22.15625 C 21.113281 21.230469 22.140625 20.011719 23 18.6875 C 24.15625 16.90625 25 14.917969 25 13 C 25 8.042969 20.957031 4 16 4 Z M 16 6 C 19.878906 6 23 9.121094 23 13 C 23 14.308594 22.355469 16.035156 21.34375 17.59375 C 20.441406 18.984375 19.253906 20.222656 18.15625 21 L 13.84375 21 C 12.746094 20.222656 11.558594 18.984375 10.65625 17.59375 C 9.644531 16.035156 9 14.308594 9 13 C 9 9.121094 12.121094 6 16 6 Z M 14.25 23 L 17.75 23 C 17.828125 23.054688 17.910156 23.09375 18 23.125 L 18 25 L 14 25 L 14 23.125 C 14.089844 23.09375 14.171875 23.054688 14.25 23 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
