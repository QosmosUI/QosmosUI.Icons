// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcElectricalSensor : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "fill", "#B2EBF2");
		builder.AddAttribute(15, "cx", "32");
		builder.AddAttribute(16, "cy", "24");
		builder.AddAttribute(17, "r", "9");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "fill", "#4DD0E1");
		builder.AddAttribute(20, "d", "M32,12c-6.6,0-12,5.4-12,12c0,6.6,5.4,12,12,12s12-5.4,12-12C44,17.4,38.6,12,32,12z M32,32 c-4.4,0-8-3.6-8-8s3.6-8,8-8s8,3.6,8,8S36.4,32,32,32z");
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.AddAttribute(22, "fill", "#3F51B5");
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "25.4,22 19.8,5.1 13.6,27.7 11.4,22 4,22 4,26 8.6,26 14.4,40.3 20.2,18.9 22.6,26 30,26 30,22");
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "cx", "32");
		builder.AddAttribute(27, "cy", "24");
		builder.AddAttribute(28, "r", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
