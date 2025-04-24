// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcPhotoReel : ComponentBase
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
		builder.AddAttribute(14, "fill", "#673AB7");
		builder.AddAttribute(15, "d", "M10,9c-2.2,0-4,1.8-4,4v26c0,2.2,1.8,4,4,4h16c2.2,0,4-1.8,4-4V13c0-2.2-1.8-4-4-4");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#311B92");
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "x", "14");
		builder.AddAttribute(20, "y", "13");
		builder.AddAttribute(21, "width", "2");
		builder.AddAttribute(22, "height", "26");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M24,9V7c0-1.2-0.8-2-2-2h-8c-1.2,0-2,0.8-2,2v2H24z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#D84315");
		builder.AddAttribute(27, "d", "M30,13H16v26h14V13z M21,37h-3v-4h3V37z M21,19h-3v-4h3V19z M27,37h-3v-4h3V37z M24,19v-4h3v4H24z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#FF5722");
		builder.AddAttribute(30, "d", "M30,13v2h3v4h-3v14h3v4h-3v2h12V13H30z M39,37h-3v-4h3V37z M39,19h-3v-4h3V19z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
