// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDebt : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "#FFB74D");
		builder.AddAttribute(15, "d", "M10,12c-2.8,0-5-2.2-5-5s2.2-5,5-5s5,2.2,5,5S12.8,12,10,12z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#607D8B");
		builder.AddAttribute(18, "d", "M2,22v8l3,2l1,14h8l1-14l3-2v-8c0-4.4-3.6-8-8-8h0C5.6,14,2,17.6,2,22z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#263238");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M22.4,40.4c-0.6,2.5-1,3.6-2.4,3.6c-0.6,0-1.2-0.5-1.9-1.1c-1-0.8-2.2-1.9-4.1-1.9v2c1.1,0,1.9,0.7,2.8,1.4 c0.9,0.7,1.9,1.6,3.2,1.6c3.1,0,3.8-2.9,4.4-5.2C25,38.2,25.4,37,27,37v-2C23.7,35,22.9,38.1,22.4,40.4z");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "14.4,40 10,40 10,44 14.1,44");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "circle");
		builder.AddAttribute(26, "fill", "#4CAF50");
		builder.AddAttribute(27, "cx", "36");
		builder.AddAttribute(28, "cy", "36");
		builder.AddAttribute(29, "r", "10");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "fill", "#fff");
		builder.AddAttribute(32, "d", "M35,34c0.1,0.2,0.1,0.3,0.3,0.4c0.1,0.1,0.3,0.2,0.5,0.4c0.2,0.1,0.5,0.2,0.8,0.3c0.5,0.2,0.9,0.4,1.3,0.6 c0.4,0.2,0.7,0.4,1,0.7c0.3,0.3,0.5,0.6,0.7,0.9c0.2,0.4,0.2,0.8,0.2,1.3c0,0.4-0.1,0.8-0.2,1.2c-0.1,0.4-0.3,0.7-0.6,0.9 c-0.3,0.3-0.6,0.5-0.9,0.6c-0.4,0.2-0.8,0.3-1.2,0.3v1.5h-1.2v-1.5c-0.4,0-0.8-0.1-1.2-0.3c-0.4-0.2-0.7-0.4-1-0.6 c-0.3-0.3-0.5-0.6-0.7-1.1c-0.2-0.4-0.3-0.9-0.3-1.5h2.2c0,0.4,0,0.7,0.1,0.9c0.1,0.2,0.2,0.4,0.4,0.6c0.2,0.1,0.3,0.2,0.5,0.3 c0.2,0.1,0.4,0.1,0.6,0.1c0.2,0,0.4,0,0.6-0.1c0.2-0.1,0.3-0.2,0.4-0.3c0.1-0.1,0.2-0.3,0.3-0.4c0.1-0.2,0.1-0.3,0.1-0.5 c0-0.2,0-0.4-0.1-0.6c-0.1-0.2-0.1-0.3-0.3-0.4c-0.1-0.1-0.3-0.3-0.5-0.4c-0.2-0.1-0.4-0.2-0.7-0.3c-0.5-0.2-0.9-0.4-1.3-0.6 c-0.4-0.2-0.7-0.4-1-0.7c-0.3-0.3-0.5-0.6-0.7-0.9c-0.2-0.4-0.2-0.8-0.2-1.3c0-0.4,0.1-0.8,0.2-1.2c0.1-0.3,0.3-0.7,0.6-0.9 c0.3-0.3,0.6-0.5,0.9-0.6c0.4-0.2,0.8-0.3,1.2-0.3v-1.6h1.2v1.6c0.4,0.1,0.8,0.2,1.2,0.4c0.4,0.2,0.6,0.4,0.9,0.7 c0.2,0.3,0.4,0.6,0.6,1c0.1,0.4,0.2,0.9,0.2,1.4h-2.2c0-0.6-0.1-1-0.4-1.3c-0.2-0.3-0.6-0.4-1-0.4c-0.2,0-0.4,0-0.6,0.1 c-0.2,0.1-0.3,0.2-0.4,0.3C35.1,32.7,35,32.8,35,33s-0.1,0.3-0.1,0.5C34.9,33.7,34.9,33.9,35,34z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
