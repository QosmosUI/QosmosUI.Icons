// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlinePin : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20,4H4C2.9,4,2,4.9,2,6v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6C22,4.9,21.1,4,20,4z M20,18H4V6h16V18z");
		builder.CloseElement();
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "points", "6.49,10.5 6.49,15 7.64,15 7.64,9 6.77,9 5.01,10.27 5.59,11.16");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M11.47,10.05c0.5,0,0.81,0.32,0.81,0.72c0,0.37-0.14,0.64-0.54,1.06c-0.36,0.38-1.06,1.08-2.13,2.15V15h3.89v-0.99h-2.37 l-0.03-0.05c0.68-0.68,1.15-1.14,1.4-1.39c0.61-0.6,0.92-1.22,0.92-1.86c0-0.24-0.05-1.04-0.91-1.48C12.04,9,11.25,8.87,10.56,9.2 c-0.82,0.39-0.99,1.13-1,1.15l1.01,0.42C10.67,10.44,10.95,10.05,11.47,10.05z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M16.99,13.94c-0.83,0-0.99-0.76-1.02-0.86l-1.03,0.41c0.45,1.59,2.01,1.51,2.05,1.51c1.2,0,1.68-0.72,1.76-0.85 c0.32-0.49,0.36-1.24-0.01-1.76c-0.17-0.24-0.4-0.41-0.68-0.52V11.8c0.2-0.1,0.37-0.26,0.52-0.48c0.26-0.41,0.31-1.07-0.02-1.57 C18.48,9.64,18.03,9,16.94,9c-1.26,0-1.74,0.9-1.85,1.24l0.99,0.41c0.11-0.32,0.35-0.64,0.85-0.64c0.44,0,0.75,0.26,0.75,0.65 c0,0.58-0.55,0.72-0.88,0.72h-0.46v1h0.5c0.56,0,1.04,0.24,1.04,0.79C17.88,13.66,17.4,13.94,16.99,13.94z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
