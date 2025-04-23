// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpSynagogue : ComponentBase
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
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M6,8v13h4v-7h4v7h4V8l-6-5L6,8z M13.5,10c0,0.83-0.67,1.5-1.5,1.5s-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5S13.5,9.17,13.5,10z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M3,5C1.9,5,1,5.9,1,7v1h4V7C5,5.9,4.1,5,3,5z");
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "12");
		builder.AddAttribute(26, "width", "4");
		builder.AddAttribute(27, "x", "1");
		builder.AddAttribute(28, "y", "9");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M21,5c-1.1,0-2,0.9-2,2v1h4V7C23,5.9,22.1,5,21,5z");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "height", "12");
		builder.AddAttribute(33, "width", "4");
		builder.AddAttribute(34, "x", "19");
		builder.AddAttribute(35, "y", "9");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
