// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcRefresh : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#1565C0");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M13,13c0-3.3,2.7-6,6-6h10c3.3,0,6,2.7,6,6h4c0-5.5-4.5-10-10-10H19C13.5,3,9,7.5,9,13v11.2h4V13z");
		builder.CloseElement();
		builder.OpenElement(17, "polygon");
		builder.AddAttribute(18, "points", "4.6,22 11,30.4 17.4,22");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#1565C0");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M35,35c0,3.3-2.7,6-6,6H19c-3.3,0-6-2.7-6-6H9c0,5.5,4.5,10,10,10h10c5.5,0,10-4.5,10-10V23h-4V35z");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "30.6,26 37,17.6 43.4,26");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
