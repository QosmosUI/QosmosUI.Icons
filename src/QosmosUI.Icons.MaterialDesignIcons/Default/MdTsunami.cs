// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Default;

public class MdTsunami : ComponentBase
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
		builder.AddAttribute(21, "d", "M18.67,17.63c-3.8,2.8-6.12,0.4-6.67,0c-0.66,0.49-2.92,2.76-6.67,0C3.43,19.03,2.65,19,2,19v2c1.16,0,2.3-0.32,3.33-0.93 c2.06,1.22,4.61,1.22,6.67,0c2.06,1.22,4.61,1.22,6.67,0C19.7,20.68,20.84,21,22,21v-2C21.34,19,20.5,18.98,18.67,17.63z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M19.33,12H22v-2h-2.67C17.5,10,16,8.5,16,6.67c0-1.02,0.38-1.74,1.09-3.34C15.72,3.12,15.09,3,14,3 C7.36,3,2.15,8.03,2.01,14.5c0,0-0.01,2-0.01,2c1.16,0,2.3-0.32,3.33-0.93c2.06,1.22,4.61,1.22,6.67,0c2.06,1.22,4.61,1.22,6.67,0 c1.03,0.61,2.17,0.93,3.33,0.93v-2c-0.66,0-1.5-0.02-3.33-1.37c-3.8,2.8-6.12,0.4-6.67,0c-0.9,0.67-0.54,0.41-0.91,0.63 C10.39,12.82,10,11.7,10,10.5c0-2.58,1.77-4.74,4.21-5.33C14.08,5.68,14,6.19,14,6.67C14,9.61,16.39,12,19.33,12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
