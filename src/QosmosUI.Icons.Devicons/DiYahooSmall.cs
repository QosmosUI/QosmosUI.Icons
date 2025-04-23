// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons;

public class DiYahooSmall : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
		builder.AddAttribute(14, "d", "M22.905 12.869c0.125-0.025 0.312-0.066 0.522-0.112h1.63l0.254-0.375c0.005-0.003 0.015-0.004 0.020-0.004l0.631-0.911c-0.009 0-0.024-0.002-0.031-0.002l0.066-0.099h-8.835l0.34 1.39h2.411l-4.057 3.662c-0.828-1.143-2.769-3.526-4.122-5.498h3.037v-1.057l0.035-0.234c-0.009-0.002-0.026-0.004-0.035-0.004v-0.095h-10.074v1.391h2.987c1.16 0.907 5.594 6.444 5.779 6.997 0.074 0.517 0.142 3.57-0.076 3.8-0.436 0.461-2.425 0.339-2.904 0.373l-0.166 0.946c0.876 0.026 3.727-0.071 4.613-0.071 1.747 0 4.805-0.008 5.237 0.025l0.053-0.992c-0.441-0.075-2.849-0.009-3.182-0.085-0.074-0.481-0.155-3.694-0.081-4.027 0.333-0.959 5.392-4.868 5.947-5.017zM24.372 20.464l1.353 0.108 1.577-6.090c-0.263-0.009-2.656-0.235-2.966-0.295l0.037 6.278zM24.138 21.441l0.008 1.486 0.685 0.060 0.74 0.055 0.217-1.456-0.78-0.038z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
