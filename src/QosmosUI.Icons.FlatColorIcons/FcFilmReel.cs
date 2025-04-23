// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcFilmReel : ComponentBase
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
		builder.AddAttribute(15, "d", "M43,39V24h-4v15c0,5,4,9,9,9v-4C45.2,44,43,41.8,43,39z");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "fill", "#90A4AE");
		builder.AddAttribute(18, "cx", "24");
		builder.AddAttribute(19, "cy", "24");
		builder.AddAttribute(20, "r", "19");
		builder.CloseElement();
		builder.OpenElement(21, "circle");
		builder.AddAttribute(22, "fill", "#37474F");
		builder.AddAttribute(23, "cx", "24");
		builder.AddAttribute(24, "cy", "24");
		builder.AddAttribute(25, "r", "2");
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.AddAttribute(27, "fill", "#253278");
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "24");
		builder.AddAttribute(30, "cy", "14");
		builder.AddAttribute(31, "r", "5");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "24");
		builder.AddAttribute(34, "cy", "34");
		builder.AddAttribute(35, "r", "5");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "cx", "34");
		builder.AddAttribute(38, "cy", "24");
		builder.AddAttribute(39, "r", "5");
		builder.CloseElement();
		builder.OpenElement(40, "circle");
		builder.AddAttribute(41, "cx", "14");
		builder.AddAttribute(42, "cy", "24");
		builder.AddAttribute(43, "r", "5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
