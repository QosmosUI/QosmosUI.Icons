// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcElectronics : ComponentBase
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
		builder.AddAttribute(14, "fill", "#FF9800");
		builder.AddAttribute(15, "d", "M44,18v-4H34V4h-4v10h-4V4h-4v10h-4V4h-4v10H4v4h10v4H4v4h10v4H4v4h10v10h4V34h4v10h4V34h4v10h4V34h10v-4H34 v-4h10v-4H34v-4H44z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#4CAF50");
		builder.AddAttribute(18, "d", "M8,12v24c0,2.2,1.8,4,4,4h24c2.2,0,4-1.8,4-4V12c0-2.2-1.8-4-4-4H12C9.8,8,8,9.8,8,12z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#37474F");
		builder.AddAttribute(21, "d", "M31,31H17c-1.1,0-2-0.9-2-2V19c0-1.1,0.9-2,2-2h14c1.1,0,2,0.9,2,2v10C33,30.1,32.1,31,31,31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
