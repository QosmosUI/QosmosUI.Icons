// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiOnedrive : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.953 23.012c-1.393-0.348-2.169-1.455-2.172-3.099-0.001-0.525 0.037-0.777 0.168-1.115 0.321-0.828 1.173-1.453 2.292-1.683 0.557-0.114 0.729-0.237 0.729-0.522 0-0.089 0.066-0.355 0.147-0.591 0.368-1.070 1.050-1.963 1.779-2.328 0.763-0.382 1.147-0.468 2.070-0.463 1.31 0.007 1.964 0.291 2.878 1.251l0.503 0.528 0.45-0.156c2.18-0.754 4.353 0.53 4.528 2.676l0.048 0.587 0.429 0.154c1.226 0.439 1.802 1.361 1.698 2.717-0.068 0.887-0.483 1.595-1.14 1.946l-0.309 0.165-6.861 0.013c-5.272 0.010-6.948-0.009-7.238-0.081v0zM6.809 22.065c-0.813-0.193-1.675-0.912-2.079-1.733-0.229-0.466-0.241-0.535-0.241-1.359 0-0.784 0.020-0.91 0.202-1.299 0.385-0.821 1.122-1.414 2.047-1.647 0.195-0.049 0.379-0.128 0.408-0.174s0.061-0.301 0.072-0.566c0.064-1.642 1.142-3.089 2.646-3.554 0.813-0.251 1.834-0.189 2.718 0.164 0.28 0.112 0.249 0.136 0.842-0.641 0.351-0.46 1.059-1.032 1.639-1.323 0.626-0.314 1.277-0.459 2.055-0.457 2.176 0.005 4.051 1.366 4.744 3.443 0.222 0.664 0.21 0.849-0.051 0.855-0.114 0.002-0.441 0.065-0.726 0.139l-0.519 0.135-0.473-0.473c-1.335-1.335-3.513-1.623-5.364-0.71-0.74 0.365-1.334 0.888-1.783 1.57-0.32 0.486-0.728 1.394-0.728 1.619 0 0.16-0.129 0.24-0.682 0.421-1.711 0.561-2.709 1.857-2.709 3.515 0 0.604 0.156 1.342 0.371 1.765 0.081 0.16 0.127 0.311 0.101 0.337-0.066 0.066-2.194 0.044-2.489-0.026v0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
