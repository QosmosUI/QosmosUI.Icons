// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcPaid : ComponentBase
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
		builder.AddAttribute(14, "fill", "#2E7D32");
		builder.AddAttribute(15, "d", "M25.4,5.6c-0.8-0.8-2-0.8-2.8,0l-12,12c-0.8,0.8-0.8,2,0,2.8C11,20.8,11.5,21,12,21s1-0.2,1.4-0.6l12-12 C26.2,7.6,26.2,6.4,25.4,5.6z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#1B5E20");
		builder.AddAttribute(18, "d", "M37.4,17.6l-12-12c-0.8-0.8-2-0.8-2.8,0c-0.8,0.8-0.8,2,0,2.8l12,12C35,20.8,35.5,21,36,21s1-0.2,1.4-0.6 C38.2,19.6,38.2,18.4,37.4,17.6z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#388E3C");
		builder.AddAttribute(21, "d", "M37.4,41H10.6c-1,0-1.8-0.7-2-1.6L5,21h38l-3.7,18.4C39.1,40.3,38.3,41,37.4,41z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#4CAF50");
		builder.AddAttribute(24, "d", "M43,23H5c-1.1,0-2-0.9-2-2v-2c0-1.1,0.9-2,2-2h38c1.1,0,2,0.9,2,2v2C45,22.1,44.1,23,43,23z");
		builder.CloseElement();
		builder.OpenElement(25, "polygon");
		builder.AddAttribute(26, "fill", "#DCEDC8");
		builder.AddAttribute(27, "points", "30.8,24.8 22.9,32.7 19.2,28.9 17,31.1 22.9,37 33,26.9");
		builder.CloseElement();
		builder.CloseElement();
    }
}
