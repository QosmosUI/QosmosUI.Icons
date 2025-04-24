// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBigDiamondRing : ComponentBase
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
		builder.AddAttribute(14, "d", "M201.837 53.087L177.547 21h55.676zM278.766 21l30.82 31.465L333.065 21h-54.298zm12.428 38.12L256 23.18l-35.25 35.985h70.5zm82.091 0l-23.511-30.855-23.003 30.9h46.57zM161.096 28.683L138.5 59.188h45.746zm51.248 48.242L256 196.821l43.69-119.896h-87.38zm-73.166 0l90.384 99.017-36.153-99.017h-54.231zm233.712 0h-54.23l-36.076 99.017zm-19.455 48.142l-29.059 31.838a154.298 154.298 0 0 1 85.786 138.119C410.14 380.008 340.995 449.197 256 449.197s-154.14-69.144-154.14-154.14a154.298 154.298 0 0 1 85.787-138.119L158.588 125.1a196.044 196.044 0 0 0-98.53 169.924C60.057 403.056 147.955 491 256 491c108.044 0 195.943-87.899 195.943-195.943a196.044 196.044 0 0 0-98.542-169.99z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
