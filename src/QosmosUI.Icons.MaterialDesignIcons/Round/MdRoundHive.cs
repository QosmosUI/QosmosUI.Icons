// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHive : ComponentBase
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
		builder.AddAttribute(25, "d", "M14.09,7.51l1.2-2c0.19-0.32,0.19-0.71,0-1.03l-1.2-2C13.91,2.18,13.58,2,13.23,2h-2.45c-0.35,0-0.68,0.18-0.86,0.49 l-1.2,2c-0.19,0.32-0.19,0.71,0,1.03l1.2,2C10.09,7.82,10.42,8,10.77,8h2.45C13.58,8,13.91,7.82,14.09,7.51z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M9.91,9.49l-1.2,2c-0.19,0.32-0.19,0.71,0,1.03l1.2,2c0.18,0.3,0.51,0.49,0.86,0.49h2.46c0.35,0,0.68-0.18,0.86-0.49 l1.2-2c0.19-0.32,0.19-0.71,0-1.03l-1.2-2C13.91,9.18,13.58,9,13.23,9h-2.46C10.42,9,10.09,9.18,9.91,9.49z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M17.01,11.51h2.45c0.35,0,0.68-0.18,0.86-0.49l1.2-2c0.19-0.32,0.19-0.71,0-1.03l-1.2-2c-0.18-0.3-0.51-0.49-0.86-0.49 h-2.45c-0.35,0-0.68,0.18-0.86,0.49l-1.2,2c-0.19,0.32-0.19,0.71,0,1.03l1.2,2C16.34,11.33,16.66,11.51,17.01,11.51z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M19.47,12.51h-2.46c-0.35,0-0.68,0.18-0.86,0.49l-1.2,2c-0.19,0.32-0.19,0.71,0,1.03l1.2,2c0.18,0.3,0.51,0.49,0.86,0.49 h2.46c0.35,0,0.68-0.18,0.86-0.49l1.2-2c0.19-0.32,0.19-0.71,0-1.03l-1.2-2C20.15,12.7,19.82,12.51,19.47,12.51z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M7.84,11.03l1.2-2c0.19-0.32,0.19-0.71,0-1.03l-1.2-2C7.66,5.7,7.34,5.51,6.99,5.51H4.53C4.18,5.51,3.85,5.7,3.67,6 l-1.2,2c-0.19,0.32-0.19,0.71,0,1.03l1.2,2c0.18,0.3,0.51,0.49,0.86,0.49h2.45C7.34,11.51,7.66,11.33,7.84,11.03z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M6.99,12.51H4.53c-0.35,0-0.68,0.18-0.86,0.49l-1.2,2c-0.19,0.32-0.19,0.71,0,1.03l1.2,2c0.18,0.3,0.51,0.49,0.86,0.49 h2.46c0.35,0,0.68-0.18,0.86-0.49l1.2-2c0.19-0.32,0.19-0.71,0-1.03l-1.2-2C7.66,12.7,7.34,12.51,6.99,12.51z");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M9.91,16.49l-1.2,2c-0.19,0.32-0.19,0.71,0,1.03l1.2,2c0.18,0.3,0.51,0.49,0.86,0.49h2.46c0.35,0,0.68-0.18,0.86-0.49 l1.2-2c0.19-0.32,0.19-0.71,0-1.03l-1.2-2c-0.18-0.3-0.51-0.49-0.86-0.49h-2.46C10.42,16,10.09,16.18,9.91,16.49z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
