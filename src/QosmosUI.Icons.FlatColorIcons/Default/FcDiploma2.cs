// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcDiploma2 : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "9");
		builder.AddAttribute(15, "y", "4");
		builder.AddAttribute(16, "fill", "#FBE9E7");
		builder.AddAttribute(17, "width", "30");
		builder.AddAttribute(18, "height", "40");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#F4511E");
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "30,37 32.8,37 27.8,32 25,34.8 30,39.8");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "18,37 15.2,37 20.2,32 23,34.8 18,39.8");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "15");
		builder.AddAttribute(27, "y", "13");
		builder.AddAttribute(28, "fill", "#FF8A65");
		builder.AddAttribute(29, "width", "18");
		builder.AddAttribute(30, "height", "4");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "15");
		builder.AddAttribute(33, "y", "20");
		builder.AddAttribute(34, "fill", "#FF8A65");
		builder.AddAttribute(35, "width", "18");
		builder.AddAttribute(36, "height", "2");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "fill", "#FF8A65");
		builder.AddAttribute(39, "d", "M24,26c-2.8,0-5,2.2-5,5s2.2,5,5,5s5-2.2,5-5S26.8,26,24,26z M24,34c-1.7,0-3-1.3-3-3s1.3-3,3-3s3,1.3,3,3 S25.7,34,24,34z");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "fill", "#FF8A65");
		builder.AddAttribute(42, "d", "M8,3v42h32V3H8z M38,40c-1.7,0-3,1.3-3,3H13c0-1.7-1.3-3-3-3V8c1.7,0,3-1.3,3-3h22c0,1.7,1.3,3,3,3V40z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
