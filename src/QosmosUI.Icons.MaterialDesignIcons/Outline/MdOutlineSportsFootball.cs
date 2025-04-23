// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineSportsFootball : ComponentBase
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
		builder.AddAttribute(21, "d", "M20.31,3.69C19.99,3.36,18.37,3,16.26,3c-3.03,0-7.09,0.75-9.8,3.46C1.87,11.05,2.9,19.52,3.69,20.31 C4.01,20.64,5.63,21,7.74,21c3.03,0,7.09-0.75,9.8-3.46C22.13,12.95,21.1,4.48,20.31,3.69z M7.74,19c-1.14,0-2.02-0.12-2.53-0.23 c-0.18-0.79-0.3-2.21-0.17-3.83l4.01,4.01C8.53,18.99,8.08,19,7.74,19z M16.13,16.13c-1.33,1.33-3.06,2.05-4.66,2.44l-6.04-6.04 c0.42-1.68,1.16-3.37,2.45-4.65c1.32-1.32,3.05-2.04,4.64-2.43l6.05,6.05C18.15,13.17,17.4,14.85,16.13,16.13z M18.96,9.09 l-4.03-4.03C15.45,5.01,15.91,5,16.26,5c1.14,0,2.02,0.12,2.53,0.23C18.97,6.02,19.09,7.45,18.96,9.09z");
		builder.CloseElement();
		builder.OpenElement(22, "rect");
		builder.AddAttribute(23, "height", "1.98");
		builder.AddAttribute(24, "transform", "matrix(0.7071 -0.7071 0.7071 0.7071 -4.9706 12.0001)");
		builder.AddAttribute(25, "width", "7.92");
		builder.AddAttribute(26, "x", "8.04");
		builder.AddAttribute(27, "y", "11.01");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
