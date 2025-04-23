// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiKnifeThrust : ComponentBase
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
		builder.AddAttribute(14, "d", "M47.688 19.156c-.376-.003-.748.016-1.126.032-6.044.245-12.252 2.815-17.28 7.843-10.057 10.058-10.297 24.924-1.72 33.5 3.94 3.94 9.21 6.034 14.72 6.157l3.062-3.093L67.5 41.437l1.406-1.406c-.123-5.515-2.217-10.78-6.156-14.718-4.022-4.02-9.423-6.114-15.063-6.156zm28.28 40.25L63.063 72.313c13.653 33.245 37.167 56.274 67.438 73.718l18.75-18.75C130.385 97.324 105.988 74.1 75.97 59.407zm129.344 38.25L99.906 203.094l23.844 23.844c29.782-40.624 65.415-75.33 105.5-105.344l-23.938-23.938zm12.813 56.406c-22.467 18.703-43.183 39.077-61.875 61.438 34.053 43.905 76.278 82.775 122.406 112.375-20.858 1.702-40.402 1.278-58.562-1.28 34.15 24.845 71.227 45.65 110.25 61.155-28.237 2.647-54.58 2.25-78.97-1.188 72.535 52.773 155.472 91.19 243.064 107.47-20.59-94.733-58.107-178.44-109.844-249.094 3.565 24.952 4.537 52.326 2.47 82.312-16.075-41.127-36.744-78.823-61.564-112.72 2.653 18.574 3.49 38.852 2.22 60.94-29.64-47.287-66.485-88.237-109.595-121.408z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
