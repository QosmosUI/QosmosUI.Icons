// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcNightPortrait : ComponentBase
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
		builder.AddAttribute(14, "fill", "#40C4FF");
		builder.AddAttribute(15, "d", "M42.9,6.3C43.6,7.4,44,8.6,44,10c0,3.9-3.1,7-7,7c-0.7,0-1.3-0.1-1.9-0.3c1.2,2,3.4,3.3,5.9,3.3 c3.9,0,7-3.1,7-7C48,9.8,45.9,7.1,42.9,6.3z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#B39DDB");
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "31");
		builder.AddAttribute(20, "cy", "19");
		builder.AddAttribute(21, "r", "2");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "13");
		builder.AddAttribute(24, "cy", "19");
		builder.AddAttribute(25, "r", "2");
		builder.CloseElement();
		builder.OpenElement(26, "polygon");
		builder.AddAttribute(27, "points", "22,37 17,31 17,25 27,25 27,31");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#D1C4E9");
		builder.AddAttribute(30, "d", "M31,13c0-7.6-18-5-18,0c0,1.1,0,5.9,0,7c0,5,4,9,9,9s9-4,9-9C31,18.9,31,14.1,31,13z");
		builder.CloseElement();
		builder.OpenElement(31, "g");
		builder.AddAttribute(32, "fill", "#673AB7");
		builder.OpenElement(33, "circle");
		builder.AddAttribute(34, "cx", "26");
		builder.AddAttribute(35, "cy", "19");
		builder.AddAttribute(36, "r", "1");
		builder.CloseElement();
		builder.OpenElement(37, "circle");
		builder.AddAttribute(38, "cx", "18");
		builder.AddAttribute(39, "cy", "19");
		builder.AddAttribute(40, "r", "1");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M22,4c-6.1,0-10,4.9-10,11c0,0.8,0,2.3,0,2.3l2,1.7v-5l12-4l4,4v5l2-1.7c0,0,0-1.5,0-2.3c0-4-1-8-6-9l-1-2 H22z");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M27,31L27,31c0,0-2,1-5,1s-5-1-5-1S6,33,6,44h32C38,33,27,31,27,31z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
