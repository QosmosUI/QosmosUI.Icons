// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiZigArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.678 69.63V219.51l36.218-25.17-14.99-29.723 68.918-44.51-90.146-50.48zm108.597 60.81l-63.117 40.763 14.735 29.22-60.215 41.847v22.896l45.576 18.45 72.096-50.1-14.99-29.725 63.58-41.058-57.665-32.29zm76.114 42.624l-57.78 37.313 14.738 29.22-75.4 52.397 78.072 31.604 61.626-42.825-14.99-29.724 61.766-39.89-68.033-38.096zm140.298 3.985l-28.862 58.417-24.955-13.975-55.962 36.143 14.737 29.22-64.93 45.122 65.582 26.548 61.777-42.93-14.988-29.726 83.607-53.995-36.005-54.826zm46.263 70.448l-69.614 44.957 14.736 29.22-95.69 66.5-14.52 29.387 96.576-6.96 78.556-54.59-14.99-29.725 39.807-25.707-34.86-53.082zm45.12 68.703l-25.814 16.673 14.734 29.22-66.01 45.874 131.145-9.453L437.07 316.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
