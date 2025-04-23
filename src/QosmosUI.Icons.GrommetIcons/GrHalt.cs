// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrHalt : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M8,23 C10,23 12.9996892,23 15,23 C18,23 19,21 19,18 L19,6 C19,4.00000008 18,3.99999992 17.5,4 C17,4.00000008 15.9998779,4.00000008 15.9998779,5.99999984 C15.9998779,7.9999996 15.9998782,13 15.9998782,13 C15.9998782,13 15.9998784,5.00000004 15.9998782,4 C15.9998779,2.99999996 15.9998779,2 14.5,2 C13.0001221,2 12.9996891,2.99999994 12.9996891,4.00000006 C12.9996891,5.00000017 12.9996892,13 12.9996892,13 C12.9996892,13 12.9996891,4.00000006 12.9996891,3.00000006 C12.9996891,2.00000006 13,1.00000001 11.5,0.999999996 C10,0.999999981 10,2.00000006 10,3 L10,13 L10,4 C10,3 10.029402,2 8.5,2 C7,2 7,3 7,4 L7,18 L7,14 C7,13 6.44999986,12 5.00000005,12 C5,12 4,12 4,12 C4,12 4.00000001,14.0384045 4,18 C3.99999999,21.9615955 6,23.023861 8,23 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
