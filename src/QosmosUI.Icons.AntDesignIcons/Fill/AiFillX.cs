// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.AntDesignIcons.Fill;

public class AiFillX : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 1024 1024";

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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "fillRule", "evenodd");
		builder.AddAttribute(16, "stroke", "none");
		builder.AddAttribute(17, "stroke-width", "1");
		builder.AddAttribute(18, "transform", "translate(112 112)");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M711.111 800H88.89C39.8 800 0 760.2 0 711.111V88.89C0 39.8 39.8 0 88.889 0H711.11C760.2 0 800 39.8 800 88.889V711.11C800 760.2 760.2 800 711.111 800");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "fillRule", "nonzero");
		builder.AddAttribute(23, "d", "M628 623H484.942L174 179h143.058zm-126.012-37.651h56.96L300.013 216.65h-56.96z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "fillRule", "nonzero");
		builder.AddAttribute(26, "d", "M219.296885 623 379 437.732409 358.114212 410 174 623z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "fillRule", "nonzero");
		builder.AddAttribute(29, "d", "M409 348.387347 429.212986 377 603 177 558.330417 177z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
