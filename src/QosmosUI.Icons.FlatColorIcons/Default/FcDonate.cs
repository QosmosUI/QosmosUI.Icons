// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcDonate : ComponentBase
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
		builder.OpenElement(13, "polygon");
		builder.AddAttribute(14, "fill", "#E69329");
		builder.AddAttribute(15, "points", "11.7,21.6 16.8,31.5 26.3,27.6 30.7,14.9 15.9,15.7");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "fill", "#546E7A");
		builder.AddAttribute(18, "cx", "15");
		builder.AddAttribute(19, "cy", "36");
		builder.AddAttribute(20, "r", "7.8");
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.AddAttribute(22, "fill", "#90A4AE");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M15,27c-5,0-9,4-9,9c0,5,4,9,9,9s9-4,9-9C24,31,20,27,15,27z M15,43c-3.9,0-7-3.1-7-7c0-3.9,3.1-7,7-7 s7,3.1,7,7C22,39.9,18.9,43,15,43z");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "14");
		builder.AddAttribute(27, "y", "33");
		builder.AddAttribute(28, "width", "2");
		builder.AddAttribute(29, "height", "8");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(30, "g");
		builder.AddAttribute(31, "fill", "#FFB74D");
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M12.9,36L12.9,36c1,1.9,3.2,2.7,5.1,1.7l16.5-8.5c1-0.5,1.7-1.2,2.2-1.9c1.7-3.2,5.6-10.7,8.2-17.2 l-18.2,8.7L21.9,26l-6.8,3.6C12.5,30.9,11.7,33.8,12.9,36z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M30.2,3L13.7,9.3c-0.7,0.2-1.5,1-2.2,1.7l-5.6,7.5c-1,1.5-1.2,3.4-0.5,5.1c0.4,1,1.7,3.4,3.1,6.1 c1.6-1.7,3.9-2.7,6.5-2.7c0.4,0,0.9,0,1.3,0.1l-2.1-4.2l4.6-4.1h8c0,0,15.5-2.2,18.2-8.7L30.2,3z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "fill", "#FFCDD2");
		builder.AddAttribute(38, "d", "M18.2,36c-1.3,0.6-2.8,0-3.3-1.3c-0.6-1.3,0-2.8,1.3-3.3C17.4,30.8,19.4,35.4,18.2,36z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
