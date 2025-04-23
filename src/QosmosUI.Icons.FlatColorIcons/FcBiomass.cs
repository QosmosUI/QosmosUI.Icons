// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcBiomass : ComponentBase
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
		builder.AddAttribute(14, "fill", "#9CCC65");
		builder.AddAttribute(15, "d", "M32,15V7H16v8L6.2,40c-0.6,1.5,0.5,3,2.1,3h31.5c1.6,0,2.6-1.6,2.1-3L32,15z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#8BC34A");
		builder.AddAttribute(18, "d", "M32,9H16c-1.1,0-2-0.9-2-2v0c0-1.1,0.9-2,2-2h16c1.1,0,2,0.9,2,2v0C34,8.1,33.1,9,32,9z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#2E7D32");
		builder.AddAttribute(21, "d", "M28,30c0,4.4-4,8-4,8s-4-3.6-4-8s4-8,4-8S28,25.6,28,30z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#388E3C");
		builder.AddAttribute(24, "d", "M31.1,32.6c-2,4-7.1,5.4-7.1,5.4s-2-5,0-8.9s7.1-5.4,7.1-5.4S33.1,28.6,31.1,32.6z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#43A047");
		builder.AddAttribute(27, "d", "M16.9,32.6c2,4,7.1,5.4,7.1,5.4s2-5,0-8.9s-7.1-5.4-7.1-5.4S14.9,28.6,16.9,32.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
