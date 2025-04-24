// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImSpinner4 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M3 8c0-0.19 0.011-0.378 0.032-0.563l-2.89-0.939c-0.092 0.487-0.141 0.989-0.141 1.502 0 2.3 0.971 4.374 2.526 5.833l1.786-2.458c-0.814-0.889-1.312-2.074-1.312-3.375zM13 8c0 1.301-0.497 2.486-1.312 3.375l1.786 2.458c1.555-1.459 2.526-3.533 2.526-5.833 0-0.513-0.049-1.015-0.141-1.502l-2.89 0.939c0.021 0.185 0.032 0.373 0.032 0.563zM9 3.1c1.436 0.292 2.649 1.199 3.351 2.435l2.89-0.939c-1.144-2.428-3.473-4.188-6.241-4.534v3.038zM3.649 5.535c0.702-1.236 1.914-2.143 3.351-2.435v-3.038c-2.769 0.345-5.097 2.105-6.241 4.534l2.89 0.939zM10.071 12.552c-0.631 0.288-1.332 0.448-2.071 0.448s-1.44-0.16-2.071-0.448l-1.786 2.458c1.144 0.631 2.458 0.99 3.857 0.99s2.713-0.359 3.857-0.99l-1.786-2.458z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
