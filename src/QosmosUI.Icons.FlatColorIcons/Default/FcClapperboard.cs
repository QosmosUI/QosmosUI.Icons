// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcClapperboard : ComponentBase
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
		builder.AddAttribute(14, "fill", "#3F51B5");
		builder.AddAttribute(15, "d", "M43.4,8.3L4,15l-0.3-2c-0.4-2.2,1.1-4.2,3.3-4.6l31.6-5.3c2.2-0.4,4.2,1.1,4.6,3.3L43.4,8.3z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#3F51B5");
		builder.AddAttribute(18, "d", "M40,41H8c-2.2,0-4-1.8-4-4V15h40v22C44,39.2,42.2,41,40,41z");
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.AddAttribute(20, "fill", "#9FA8DA");
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "18.8,6.4 23.7,11.7 27.7,11 22.7,5.7");
		builder.CloseElement();
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "10.9,7.7 15.8,13 19.8,12.3 14.8,7.1");
		builder.CloseElement();
		builder.OpenElement(25, "polygon");
		builder.AddAttribute(26, "points", "26.7,5.1 31.6,10.3 35.5,9.7 30.6,4.4");
		builder.CloseElement();
		builder.OpenElement(27, "polygon");
		builder.AddAttribute(28, "points", "34.5,3.8 39.5,9 43.4,8.3 38.5,3.1");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(29, "circle");
		builder.AddAttribute(30, "fill", "#9FA8DA");
		builder.AddAttribute(31, "cx", "7.5");
		builder.AddAttribute(32, "cy", "11.5");
		builder.AddAttribute(33, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(34, "g");
		builder.AddAttribute(35, "fill", "#9FA8DA");
		builder.OpenElement(36, "polygon");
		builder.AddAttribute(37, "points", "40,15 36,21 40,21 44,15");
		builder.CloseElement();
		builder.OpenElement(38, "polygon");
		builder.AddAttribute(39, "points", "32,15 28,21 32,21 36,15");
		builder.CloseElement();
		builder.OpenElement(40, "polygon");
		builder.AddAttribute(41, "points", "24,15 20,21 24,21 28,15");
		builder.CloseElement();
		builder.OpenElement(42, "polygon");
		builder.AddAttribute(43, "points", "16,15 12,21 16,21 20,15");
		builder.CloseElement();
		builder.OpenElement(44, "polygon");
		builder.AddAttribute(45, "points", "8,15 4,21 8,21 12,15");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
