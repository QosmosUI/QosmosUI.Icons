// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundOutdoorGrill : ComponentBase
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
		builder.AddAttribute(25, "d", "M17,22c1.66,0,3-1.34,3-3s-1.34-3-3-3c-1.3,0-2.4,0.84-2.82,2H9.14l1.99-3.06C11.42,14.98,11.71,15,12,15 s0.58-0.02,0.87-0.06l1.02,1.57c0.42-0.53,0.96-0.95,1.6-1.21l-0.6-0.93c2.1-0.95,3.64-2.9,4.02-5.24C19.01,8.54,18.52,8,17.92,8 C15.31,8,8.69,8,6.08,8C5.48,8,4.99,8.54,5.09,9.14c0.38,2.34,1.93,4.29,4.02,5.24l-3.95,6.08c-0.3,0.46-0.17,1.08,0.29,1.38h0 c0.46,0.3,1.08,0.17,1.38-0.29l1-1.55h6.34C14.6,21.16,15.7,22,17,22z M17,18c0.55,0,1,0.45,1,1c0,0.55-0.45,1-1,1s-1-0.45-1-1 C16,18.45,16.45,18,17,18z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M9.5,6.47C9.48,6.75,9.68,7,9.96,7H10c0.24,0,0.44-0.18,0.46-0.42c0.1-0.87,0.04-1.39-0.94-2.54 C9.16,3.61,8.92,3.35,8.99,2.49C9.02,2.23,8.8,2,8.53,2H8.48C8.24,2,8.03,2.19,8.01,2.43c-0.08,0.93,0.2,1.74,0.95,2.53 C9.15,5.17,9.6,5.52,9.5,6.47z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M11.99,6.47C11.96,6.75,12.17,7,12.45,7h0.03c0.24,0,0.44-0.18,0.46-0.42c0.1-0.87,0.04-1.39-0.94-2.54 c-0.36-0.43-0.61-0.69-0.53-1.55C11.5,2.23,11.28,2,11.01,2h-0.05c-0.24,0-0.45,0.19-0.47,0.43c-0.08,0.93,0.2,1.74,0.95,2.53 C11.63,5.17,12.08,5.52,11.99,6.47z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M14.5,6.47C14.48,6.75,14.68,7,14.96,7H15c0.24,0,0.44-0.18,0.46-0.42c0.1-0.87,0.04-1.39-0.94-2.54 c-0.36-0.43-0.61-0.69-0.53-1.55C14.02,2.23,13.8,2,13.53,2h-0.05c-0.24,0-0.45,0.19-0.47,0.43c-0.08,0.93,0.2,1.74,0.95,2.53 C14.15,5.17,14.6,5.52,14.5,6.47z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
