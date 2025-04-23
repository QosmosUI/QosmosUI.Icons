// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundThunderstorm : ComponentBase
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
		builder.AddAttribute(25, "d", "M17.92,7.02C17.45,4.18,14.97,2,12,2C9.82,2,7.83,3.18,6.78,5.06C4.09,5.41,2,7.74,2,10.5C2,13.53,4.47,16,7.5,16h10 c2.48,0,4.5-2.02,4.5-4.5C22,9.16,20.21,7.23,17.92,7.02z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M15.95,20.11l-0.84-0.42l0.9-1.03c0.36-0.42,0.32-1.05-0.09-1.41c-0.42-0.36-1.05-0.32-1.41,0.09l-1.75,2 c-0.2,0.23-0.29,0.55-0.23,0.85c0.06,0.3,0.26,0.56,0.53,0.7l0.84,0.42L13,22.34c-0.36,0.42-0.32,1.05,0.09,1.41 c0.19,0.17,0.42,0.25,0.66,0.25c0.28,0,0.55-0.12,0.75-0.34l1.75-2c0.2-0.23,0.29-0.55,0.23-0.85 C16.42,20.5,16.22,20.24,15.95,20.11z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M9.95,20.11L9.1,19.68l0.9-1.03c0.36-0.42,0.32-1.05-0.09-1.41c-0.42-0.36-1.05-0.32-1.41,0.09l-1.75,2 c-0.2,0.23-0.29,0.55-0.23,0.85c0.06,0.3,0.26,0.56,0.53,0.7l0.84,0.42L7,22.34c-0.36,0.42-0.32,1.05,0.09,1.41 C7.28,23.92,7.52,24,7.75,24c0.28,0,0.55-0.12,0.75-0.34l1.75-2c0.2-0.23,0.29-0.55,0.23-0.85C10.42,20.5,10.22,20.24,9.95,20.11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
