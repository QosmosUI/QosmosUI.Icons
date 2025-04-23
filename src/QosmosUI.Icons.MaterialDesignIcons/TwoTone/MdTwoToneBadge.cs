// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneBadge : ComponentBase
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
		builder.AddAttribute(18, "y", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M14,13.5h4V12h-4V13.5z M14,16.5h4V15h-4V16.5z M20,7h-5V4c0-1.1-0.9-2-2-2h-2C9.9,2,9,2.9,9,4v3H4C2.9,7,2,7.9,2,9v11 c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V9C22,7.9,21.1,7,20,7z M11,4h2v5h-2V4z M20,20H4V9h5c0,1.1,0.9,2,2,2h2c1.1,0,2-0.9,2-2h5V20 z M9,15c0.83,0,1.5-0.67,1.5-1.5c0-0.83-0.67-1.5-1.5-1.5s-1.5,0.67-1.5,1.5C7.5,14.33,8.17,15,9,15z M11.08,16.18 C10.44,15.9,9.74,15.75,9,15.75s-1.44,0.15-2.08,0.43C6.36,16.42,6,16.96,6,17.57V18h6v-0.43C12,16.96,11.64,16.42,11.08,16.18z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M13,11h-2c-1.1,0-2-0.9-2-2H4v11h16V9h-5C15,10.1,14.1,11,13,11z M9,12c0.83,0,1.5,0.67,1.5,1.5 c0,0.83-0.67,1.5-1.5,1.5s-1.5-0.67-1.5-1.5C7.5,12.67,8.17,12,9,12z M12,18H6v-0.43c0-0.6,0.36-1.15,0.92-1.39 C7.56,15.9,8.26,15.75,9,15.75s1.44,0.15,2.08,0.43c0.55,0.24,0.92,0.78,0.92,1.39V18z M18,16.5h-4V15h4V16.5z M18,13.5h-4V12h4 V13.5z");
		builder.AddAttribute(25, "opacity", ".3");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
