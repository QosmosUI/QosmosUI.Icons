// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineAdminPanelSettings : ComponentBase
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
		builder.AddAttribute(21, "cx", "17");
		builder.AddAttribute(22, "cy", "15.5");
		builder.AddAttribute(23, "fill-rule", "evenodd");
		builder.AddAttribute(24, "r", "1.12");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M17,17.5c-0.73,0-2.19,0.36-2.24,1.08c0.5,0.71,1.32,1.17,2.24,1.17 s1.74-0.46,2.24-1.17C19.19,17.86,17.73,17.5,17,17.5z");
		builder.AddAttribute(27, "fill-rule", "evenodd");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M18,11.09V6.27L10.5,3L3,6.27v4.91c0,4.54,3.2,8.79,7.5,9.82 c0.55-0.13,1.08-0.32,1.6-0.55C13.18,21.99,14.97,23,17,23c3.31,0,6-2.69,6-6C23,14.03,20.84,11.57,18,11.09z M11,17 c0,0.56,0.08,1.11,0.23,1.62c-0.24,0.11-0.48,0.22-0.73,0.3c-3.17-1-5.5-4.24-5.5-7.74v-3.6l5.5-2.4l5.5,2.4v3.51 C13.16,11.57,11,14.03,11,17z M17,21c-2.21,0-4-1.79-4-4c0-2.21,1.79-4,4-4s4,1.79,4,4C21,19.21,19.21,21,17,21z");
		builder.AddAttribute(30, "fill-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
