// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiGasPump : ComponentBase
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
		builder.AddAttribute(14, "d", "M372.533 21.966L362.7 39.524l24.878 36.62-8.488 44.453 34.125 50.234 19.025-12.923-2.898 61.932.1.003-9.272 173.553c-1.28 17.17-8.718 21.912-14.123 21.93-5.393.02-13.577-5.053-15.95-22.354l-15.988-223.815-.03-.234c-1.673-13.444-7.012-24.765-17.11-31.393-8.642-5.673-19.398-7.853-32.822-8.365v-7.13c0-23.016-3.88-36.357-11.302-43.844-7.42-7.487-20.523-11.384-43.608-11.156H141.148c-23 0-36.182 3.91-43.636 11.363-7.455 7.455-11.364 20.637-11.364 43.637v320h-25v48h288v-48h-25V147.208c11.228.57 18.628 2.538 22.944 5.37 5.138 3.374 7.793 8.046 9.105 18.466l15.994 223.912.04.28c3.114 23.126 17.402 38.15 33.883 38.09 16.48-.06 30.304-15.588 32.01-38.628l.008-.092 9.407-176.086-.113-.006 3.428-73.25-1.334-9.974-76.985-113.324zm29.35 75.236l27.69 40.756-11.583 7.87-19.82-29.18 3.713-19.446zm-292.735 8.832h192v80h-192v-80zm16 103h160v18h-160v-18zm0 32h160v18h-160v-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
