// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneLunchDining : ComponentBase
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
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "fill-opacity", ".3");
		builder.AddAttribute(22, "height", "1");
		builder.AddAttribute(23, "width", "16");
		builder.AddAttribute(24, "x", "4");
		builder.AddAttribute(25, "y", "18");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,5C8.61,5,5.01,5.81,4.18,8h15.66c-0.13-0.37-0.35-0.7-0.66-1.01C17.93,5.73,15.31,5,12,5z");
		builder.AddAttribute(28, "fill-opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M2,19c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2v-3H2V19z M4,18h16v1H4V18z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M18.66,11.5c-1.95,0-2.09,1-3.33,1c-1.19,0-1.42-1-3.33-1c-1.95,0-2.09,1-3.33,1c-1.19,0-1.42-1-3.33-1 c-1.95,0-2.09,1-3.33,1v2c1.9,0,2.17-1,3.35-1c1.19,0,1.42,1,3.33,1c1.95,0,2.09-1,3.33-1c1.19,0,1.42,1,3.33,1 c1.95,0,2.09-1,3.33-1c1.19,0,1.4,0.98,3.32,1l-0.01-1.98C20.38,12.19,20.37,11.5,18.66,11.5z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M22,9c0.02-4-4.28-6-10-6C6.29,3,2,5,2,9v1h20L22,9L22,9z M4.18,8C5.01,5.81,8.61,5,12,5c3.31,0,5.93,0.73,7.19,1.99 C19.49,7.3,19.71,7.63,19.84,8H4.18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
