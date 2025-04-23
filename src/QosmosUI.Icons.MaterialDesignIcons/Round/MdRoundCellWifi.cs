// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCellWifi : ComponentBase
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
		builder.AddAttribute(21, "d", "M20.29,7.68L7.7,20.29C7.07,20.92,7.52,22,8.41,22H21c0.55,0,1-0.45,1-1V8.39C22,7.5,20.92,7.05,20.29,7.68z M20,20h-2 v-7.22l2-2V20z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M9.61,10.68c-0.28,0.17-0.32,0.56-0.09,0.79l0.82,0.82c0.39,0.39,1.02,0.39,1.41,0l0.82-0.82 c0.23-0.23,0.18-0.62-0.09-0.79C11.61,10.14,10.49,10.14,9.61,10.68z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M8.42,9.3c1.57-1.12,3.7-1.12,5.27,0c0.36,0.26,0.85,0.22,1.16-0.1c0.39-0.39,0.35-1.06-0.1-1.38 c-2.2-1.57-5.19-1.57-7.4,0C6.9,8.14,6.85,8.81,7.25,9.2C7.57,9.52,8.06,9.56,8.42,9.3z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M16.26,6.69c0.34,0.28,0.83,0.28,1.14-0.03l0.12-0.12c0.35-0.35,0.31-0.92-0.08-1.24c-3.67-3.05-9.02-3.07-12.7-0.06 C4.31,5.59,4.27,6.23,4.66,6.61C4.98,6.94,5.5,6.98,5.85,6.69C8.86,4.21,13.25,4.21,16.26,6.69z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
