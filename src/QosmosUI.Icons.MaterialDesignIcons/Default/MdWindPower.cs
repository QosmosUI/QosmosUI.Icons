// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Default;

public class MdWindPower : ComponentBase
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
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "height", "2");
		builder.AddAttribute(22, "width", "6");
		builder.AddAttribute(23, "x", "4");
		builder.AddAttribute(24, "y", "3");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "height", "2");
		builder.AddAttribute(27, "width", "5");
		builder.AddAttribute(28, "x", "1");
		builder.AddAttribute(29, "y", "7");
		builder.CloseElement();
		builder.OpenElement(30, "rect");
		builder.AddAttribute(31, "height", "2");
		builder.AddAttribute(32, "width", "5");
		builder.AddAttribute(33, "x", "3");
		builder.AddAttribute(34, "y", "19");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M13.73,10.61c0.75,0.23,1.3,0.78,1.57,1.46l4.27-7.11c0.65-1.08,0.3-2.48-0.78-3.13c-0.87-0.52-1.99-0.41-2.73,0.29 l-3.43,3.21C12.23,5.7,12,6.23,12,6.78v3.93C12.36,10.56,12.98,10.38,13.73,10.61z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M10.61,12.27c0.16-0.52,0.48-0.96,0.89-1.27H3.28C2.02,11,1,12.02,1,13.28c0,1.02,0.67,1.91,1.65,2.19l4.51,1.29 c0.53,0.15,1.1,0.08,1.58-0.21l2.69-1.61C10.66,14.32,10.3,13.27,10.61,12.27z");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M22.21,18.61l-2.28-4.1c-0.27-0.48-0.73-0.83-1.26-0.97l-3.18-0.8c0.03,0.32,0,0.66-0.1,0.99 c-0.32,1.06-1.28,1.77-2.39,1.77c-0.61,0-0.99-0.22-1-0.22V21c-1.1,0-2,0.9-2,2h6c0-1.1-0.9-2-2-2v-4.28l4.61,4.61 c0.89,0.89,2.33,0.89,3.22,0C22.55,20.61,22.71,19.5,22.21,18.61z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M12.56,14.43c0.79,0.24,1.63-0.2,1.87-1c0.24-0.79-0.2-1.63-1-1.87c-0.79-0.24-1.63,0.2-1.87,1 C11.32,13.35,11.77,14.19,12.56,14.43z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
