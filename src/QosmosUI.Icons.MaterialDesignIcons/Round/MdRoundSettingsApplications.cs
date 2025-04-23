// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSettingsApplications : ComponentBase
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
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "12");
		builder.AddAttribute(22, "cy", "12");
		builder.AddAttribute(23, "r", "2");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M19,3H5C3.89,3,3,3.9,3,5v14c0,1.1,0.89,2,2,2h14c1.11,0,2-0.9,2-2V5C21,3.9,20.11,3,19,3z M15.75,12 c0,0.22-0.03,0.42-0.06,0.63l0.84,0.73c0.18,0.16,0.22,0.42,0.1,0.63l-0.59,1.02c-0.12,0.21-0.37,0.3-0.59,0.22l-1.06-0.36 c-0.32,0.27-0.68,0.48-1.08,0.63l-0.22,1.09c-0.05,0.23-0.25,0.4-0.49,0.4h-1.18c-0.24,0-0.44-0.17-0.49-0.4l-0.22-1.09 c-0.4-0.15-0.76-0.36-1.08-0.63l-1.06,0.36c-0.23,0.08-0.47-0.02-0.59-0.22l-0.59-1.02c-0.12-0.21-0.08-0.47,0.1-0.63l0.84-0.73 C8.28,12.42,8.25,12.22,8.25,12s0.03-0.42,0.06-0.63l-0.84-0.73c-0.18-0.16-0.22-0.42-0.1-0.63l0.59-1.02 c0.12-0.21,0.37-0.3,0.59-0.22l1.06,0.36c0.32-0.27,0.68-0.48,1.08-0.63l0.22-1.09C10.97,7.17,11.17,7,11.41,7h1.18 c0.24,0,0.44,0.17,0.49,0.4l0.22,1.09c0.4,0.15,0.76,0.36,1.08,0.63l1.06-0.36c0.23-0.08,0.47,0.02,0.59,0.22l0.59,1.02 c0.12,0.21,0.08,0.47-0.1,0.63l-0.84,0.73C15.72,11.58,15.75,11.78,15.75,12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
