// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCancer : ComponentBase
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
		builder.AddAttribute(14, "d", "M35.16 145.506C75.983 78.28 175.26 30.66 285.294 30.66c73.18 0 138.768 17.16 198.437 60.093l.464 96.793c-80.92-61.71-181.865-90.673-278.885-53.71 17.84 19.422 28.756 45.353 28.756 73.833 0 60.293-48.87 109.168-109.16 109.168-60.288 0-109.158-48.875-109.158-109.17-.005-23.08 7.168-44.522 19.413-62.162zm89.45 83.374c12.396 0 22.445-10.054 22.445-22.455 0-12.402-10.05-22.456-22.445-22.456-12.396 0-22.456 10.053-22.456 22.455 0 12.4 10.065 22.455 22.456 22.455zm260.892 47.792c-12.402 0-22.45 10.054-22.45 22.456 0 12.4 10.048 22.45 22.45 22.45 12.4 0 22.45-10.05 22.45-22.45 0-12.402-10.054-22.456-22.45-22.456zm89.45 83.374c-40.822 67.226-140.098 114.846-250.13 114.846-73.183 0-138.766-17.16-198.436-60.092l-.463-96.788c80.916 61.704 181.865 90.668 278.88 53.715-17.847-19.428-28.758-45.36-28.758-73.838 0-60.29 48.87-109.16 109.16-109.16s109.164 48.87 109.164 109.16c.004 23.073-7.17 44.51-19.42 62.156z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
