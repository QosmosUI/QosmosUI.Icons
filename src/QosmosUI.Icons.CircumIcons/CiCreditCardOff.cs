// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiCreditCardOff : ComponentBase
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
		builder.AddAttribute(14, "id", "Credit_Card_Off");
		builder.AddAttribute(15, "data-name", "Credit Card Off");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M21.94,7.64v9.3a.5.5,0,0,1-.5.5.5.5,0,0,1-.5-.5V9.64H13.49a.75.75,0,0,1,0-1.5h7.45v-.5a1.5,1.5,0,0,0-1.5-1.5H9.89a.5.5,0,0,1,0-1h9.55A2.5,2.5,0,0,1,21.94,7.64Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M8.064,14.246h-3a.5.5,0,0,1,0-1h3a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M18.935,14.248h-.944a.5.5,0,0,1,0-1h.944a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M18.76,18.05,4.01,3.3c-.46-.46-1.17.25-.71.7L4.44,5.14a2.5,2.5,0,0,0-2.38,2.5v8.72a2.5,2.5,0,0,0,2.5,2.5h13.6L20,20.7c.45.46,1.16-.25.7-.71ZM3.06,7.64a1.5,1.5,0,0,1,1.5-1.5h.88c.66.67,1.33,1.34,2,2H3.06Zm9.49,5.61h-.12a.5.5,0,0,0-.5.5.508.508,0,0,0,.5.5h1.12l3.61,3.61H4.56a1.5,1.5,0,0,1-1.5-1.5V9.64H8.94Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
