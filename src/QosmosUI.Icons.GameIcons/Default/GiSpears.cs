// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSpears : ComponentBase
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
		builder.AddAttribute(14, "d", "M433.877 19.855l-78.62 158.668 47.82 53.934-15.673 260.824h38.79l15.697-261.233 51.04-45.25-59.053-166.942zm-130.48 20.598L216.073 152.55l28.397 49.186-28.616 106.387-.102-.176-9.545 35.62.076.134-40.234 149.58h32.68l29.676-111.186.026.045 9.527-35.556-.054-.09 36.656-137.344 48.415-27.95L303.4 40.452h-.002zM111.632 153.21l14.48 116.54 44.42 11.904L193 320.648l9.555-35.66-9.256-16.1 12.022-44.87-93.69-70.81zm-49.357 74.31l-42.68 79.31 23.57 28.455L30.786 493.28h18.746L61.83 336.26l27.608-22.865-27.163-85.875h-.002zm257.06 10.878l-22.354 87.248 29.686 21.932L345.04 493.28h18.84l-18.823-149.235 21.293-28.824-47.016-76.822zm175.103 28.614l-40.108 226.27h18.98l21.128-119.188V267.012zm-339.903 38.886l-55.35 71.05 18.618 32.247-20.41 84.086h19.233l19.51-80.385 30.81-17.788-12.408-89.21h-.002zm96.623 63.645l-9.517 35.516 50.837 88.22h29.8l-71.12-123.737z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
