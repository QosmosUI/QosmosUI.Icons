// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcReadingEbook : ComponentBase
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
		builder.AddAttribute(14, "fill", "#2196F3");
		builder.AddAttribute(15, "d", "M33.5,27c-2.2-3-5.2-5-9.5-5s-7.3,2-9.5,5H33.5z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#546E7A");
		builder.AddAttribute(18, "d", "M34.1,43H13.9c-1.1,0-1.9-0.8-2-1.9l-0.8-13C11.1,27,12,26,13.1,26h21.8c1.2,0,2.1,1,2,2.1l-0.8,13 C36,42.2,35.2,43,34.1,43z");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "fill", "#B0BEC5");
		builder.AddAttribute(21, "cx", "34");
		builder.AddAttribute(22, "cy", "29");
		builder.AddAttribute(23, "r", "1");
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.AddAttribute(25, "fill", "#FFB74D");
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "24");
		builder.AddAttribute(28, "cy", "12");
		builder.AddAttribute(29, "r", "8");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M16.1,42.4L15,43.5c-0.6,0.6-1.6,0.6-2.2,0l-3.3-3.3c-0.6-0.6-0.6-1.6,0-2.2l1.1-1.1c1.3-1.3,3.1-1.3,4.4,0 l1.1,1.1C17.3,39.3,17.3,41.2,16.1,42.4z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M31.9,38l1.1-1.1c1.3-1.3,3.1-1.3,4.4,0l1.1,1.1c0.6,0.6,0.6,1.6,0,2.2l-3.3,3.3c-0.6,0.6-1.6,0.6-2.2,0 l-1.1-1.1C30.7,41.2,30.7,39.3,31.9,38z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
