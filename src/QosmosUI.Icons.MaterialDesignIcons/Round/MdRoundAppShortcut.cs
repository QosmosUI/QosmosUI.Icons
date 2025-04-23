// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAppShortcut : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M17,18H7V6h10v1h2V3c0-1.1-0.9-2-2-2H7C5.9,1,5,1.9,5,3v18c0,1.1,0.9,2,2,2h10c1.1,0,2-0.9,2-2v-4h-2V18z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M20.38,9.62l0.4,0.87c0.09,0.2,0.37,0.2,0.46,0l0.4-0.87l0.87-0.4c0.2-0.09,0.2-0.37,0-0.46l-0.87-0.4l-0.4-0.87 c-0.09-0.2-0.37-0.2-0.46,0l-0.4,0.87l-0.87,0.4c-0.2,0.09-0.2,0.37,0,0.46L20.38,9.62z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M15.54,9l-0.79,1.75L13,11.54c-0.39,0.18-0.39,0.73,0,0.91l1.75,0.79L15.54,15c0.18,0.39,0.73,0.39,0.91,0l0.79-1.75 L19,12.46c0.39-0.18,0.39-0.73,0-0.91l-1.75-0.79L16.46,9C16.28,8.61,15.72,8.61,15.54,9z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M20.77,13.5l-0.4,0.87l-0.87,0.4c-0.2,0.09-0.2,0.37,0,0.46l0.87,0.4l0.4,0.87c0.09,0.2,0.37,0.2,0.46,0l0.4-0.87 l0.87-0.4c0.2-0.09,0.2-0.37,0-0.46l-0.87-0.4l-0.4-0.87C21.14,13.31,20.86,13.31,20.77,13.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
