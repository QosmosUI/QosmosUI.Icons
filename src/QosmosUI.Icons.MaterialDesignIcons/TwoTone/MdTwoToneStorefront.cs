// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneStorefront : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M6.44,9.86L7.02,5H5.05L4.04,9.36c-0.1,0.42-0.01,0.84,0.25,1.17C4.43,10.71,4.73,11,5.23,11 C5.84,11,6.36,10.51,6.44,9.86z");
		builder.AddAttribute(23, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M9.71,11C10.45,11,11,10.41,11,9.69V5H9.04L8.49,9.52c-0.05,0.39,0.07,0.78,0.33,1.07 C9.05,10.85,9.37,11,9.71,11z");
		builder.AddAttribute(26, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M14.22,11c0.41,0,0.72-0.15,0.96-0.41c0.25-0.29,0.37-0.68,0.33-1.07L14.96,5H13v4.69 C13,10.41,13.55,11,14.22,11z");
		builder.AddAttribute(29, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M18.91,4.99L16.98,5l0.58,4.86c0.08,0.65,0.6,1.14,1.21,1.14c0.49,0,0.8-0.29,0.93-0.47 c0.26-0.33,0.35-0.76,0.25-1.17L18.91,4.99z");
		builder.AddAttribute(32, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M21.9,8.89l-1.05-4.37c-0.22-0.9-1-1.52-1.91-1.52H5.05C4.15,3,3.36,3.63,3.15,4.52L2.1,8.89 c-0.24,1.02-0.02,2.06,0.62,2.88C2.8,11.88,2.91,11.96,3,12.06V19c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2v-6.94 c0.09-0.09,0.2-0.18,0.28-0.28C21.92,10.96,22.15,9.91,21.9,8.89z M13,5h1.96l0.54,4.52c0.05,0.39-0.07,0.78-0.33,1.07 C14.95,10.85,14.63,11,14.22,11C13.55,11,13,10.41,13,9.69V5z M8.49,9.52L9.04,5H11v4.69C11,10.41,10.45,11,9.71,11 c-0.34,0-0.65-0.15-0.89-0.41C8.57,10.3,8.45,9.91,8.49,9.52z M4.29,10.53c-0.26-0.33-0.35-0.76-0.25-1.17L5.05,5h1.97L6.44,9.86 C6.36,10.51,5.84,11,5.23,11C4.73,11,4.43,10.71,4.29,10.53z M19,19H5v-6.03C5.08,12.98,5.15,13,5.23,13 c0.87,0,1.66-0.36,2.24-0.95c0.6,0.6,1.4,0.95,2.31,0.95c0.87,0,1.65-0.36,2.23-0.93c0.59,0.57,1.39,0.93,2.29,0.93 c0.84,0,1.64-0.35,2.24-0.95c0.58,0.59,1.37,0.95,2.24,0.95c0.08,0,0.15-0.02,0.23-0.03V19z M19.71,10.53 C19.57,10.71,19.27,11,18.77,11c-0.61,0-1.14-0.49-1.21-1.14L16.98,5l1.93-0.01l1.05,4.37C20.06,9.78,19.97,10.21,19.71,10.53z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
