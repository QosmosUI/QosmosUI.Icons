// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPteruges : ComponentBase
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
		builder.AddAttribute(14, "d", "M70.392 399.79l29.973 33.63 29.973-33.63V132.6H70.434V399.79zm29.973-24.75a13.662 13.662 0 1 1-13.662 13.663 13.662 13.662 0 0 1 13.652-13.673zM381.65 132.6V399.79l29.974 33.63 29.973-33.63V132.6h-59.904zm29.974 269.757a13.662 13.662 0 1 1 13.663-13.662 13.662 13.662 0 0 1-13.663 13.662zM303.84 145.925V431.34l29.972 33.63 29.973-33.63V132.598H317.05a77.875 77.875 0 0 1-13.21 13.347zm29.972 260.634a13.662 13.662 0 1 1-13.662 13.66 13.662 13.662 0 0 1 13.61-13.64zm-107.796-250v295.81L255.99 486l29.973-33.63V156.56a77.224 77.224 0 0 1-59.947 0zm43.636 284.722a13.662 13.662 0 1 1-13.663-13.662 13.662 13.662 0 0 1 13.662 13.662zM194.93 132.598h-46.726V431.34l29.973 33.63 29.973-33.63V145.945a77.886 77.886 0 0 1-13.22-13.347zm-16.71 301.306a13.662 13.662 0 1 1 13.662-13.662 13.662 13.662 0 0 1-13.663 13.662zM333.233 85.368a76.824 76.824 0 0 0-5.128-27.63h113.502v56.983H327.454a76.803 76.803 0 0 0 5.78-29.352zM70.392 57.738h113.502a77.024 77.024 0 0 0 .684 56.983H70.392V57.74zm185.597 86.998a59.368 59.368 0 1 1 59.368-59.368 59.368 59.368 0 0 1-59.37 59.368z");
		builder.AddAttribute(15, "class", "cls-2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
