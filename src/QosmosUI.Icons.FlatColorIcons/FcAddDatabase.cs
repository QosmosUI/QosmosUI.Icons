// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcAddDatabase : ComponentBase
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
		builder.AddAttribute(14, "fill", "#D1C4E9");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M38,7H10C8.9,7,8,7.9,8,9v6c0,1.1,0.9,2,2,2h28c1.1,0,2-0.9,2-2V9C40,7.9,39.1,7,38,7z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M38,19H10c-1.1,0-2,0.9-2,2v6c0,1.1,0.9,2,2,2h28c1.1,0,2-0.9,2-2v-6C40,19.9,39.1,19,38,19z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M38,31H10c-1.1,0-2,0.9-2,2v6c0,1.1,0.9,2,2,2h28c1.1,0,2-0.9,2-2v-6C40,31.9,39.1,31,38,31z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "fill", "#43A047");
		builder.AddAttribute(23, "cx", "38");
		builder.AddAttribute(24, "cy", "38");
		builder.AddAttribute(25, "r", "10");
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.AddAttribute(27, "fill", "#fff");
		builder.OpenElement(28, "rect");
		builder.AddAttribute(29, "x", "36");
		builder.AddAttribute(30, "y", "32");
		builder.AddAttribute(31, "width", "4");
		builder.AddAttribute(32, "height", "12");
		builder.CloseElement();
		builder.OpenElement(33, "rect");
		builder.AddAttribute(34, "x", "32");
		builder.AddAttribute(35, "y", "36");
		builder.AddAttribute(36, "width", "12");
		builder.AddAttribute(37, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
