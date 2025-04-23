// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpEditRoad : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "polygon");
		builder.AddAttribute(21, "points", "18,4 16,4 16,11.9 18,9.9");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "height", "16");
		builder.AddAttribute(24, "width", "2");
		builder.AddAttribute(25, "x", "4");
		builder.AddAttribute(26, "y", "4");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "height", "4");
		builder.AddAttribute(29, "width", "2");
		builder.AddAttribute(30, "x", "10");
		builder.AddAttribute(31, "y", "4");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "height", "4");
		builder.AddAttribute(34, "width", "2");
		builder.AddAttribute(35, "x", "10");
		builder.AddAttribute(36, "y", "10");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "height", "4");
		builder.AddAttribute(39, "width", "2");
		builder.AddAttribute(40, "x", "10");
		builder.AddAttribute(41, "y", "16");
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M22.56,12.59l-1.15-1.15c-0.59-0.59-1.54-0.59-2.12,0L14,16.73V20h3.27l5.29-5.29C23.15,14.12,23.15,13.17,22.56,12.59z M16.58,18.45h-1.03v-1.03L19,13.97L20.03,15L16.58,18.45z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
