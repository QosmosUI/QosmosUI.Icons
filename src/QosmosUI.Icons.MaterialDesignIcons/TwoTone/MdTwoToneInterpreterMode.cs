// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneInterpreterMode : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M15.52,15.01C15.35,15,15.18,15,15,15c-2.37,0-4.29,0.73-5.48,1.34C9.2,16.5,9,16.84,9,17.22V18l7.17,0 C15.74,17.26,15.4,16.24,15.52,15.01z M13,8c0,1.1,0.9,2,2,2s2-0.9,2-2c0-1.1-0.9-2-2-2S13,6.9,13,8z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M20.5,16.5c-0.83,0-1.5-0.67-1.5-1.5v-2.5c0-0.83,0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5V15C22,15.83,21.33,16.5,20.5,16.5z M20,20h1c0,0,0-1.54,0-1.54c1.69-0.24,3-1.7,3-3.46h-1c0,1.38-1.12,2.5-2.5,2.5S18,16.38,18,15h-1c0,1.76,1.31,3.22,3,3.46 C20,18.46,20,20,20,20z M9,12c-2.21,0-4-1.79-4-4c0-2.21,1.79-4,4-4c0.47,0,0.92,0.08,1.34,0.23C9.5,5.26,9,6.57,9,8 c0,1.43,0.5,2.74,1.34,3.77C9.92,11.92,9.47,12,9,12z M7.11,13.13C5.79,14.05,5,15.57,5,17.22V20H1v-2.78 c0-1.12,0.61-2.15,1.61-2.66C3.85,13.92,5.37,13.37,7.11,13.13z M11,8c0-2.21,1.79-4,4-4s4,1.79,4,4c0,2.21-1.79,4-4,4 S11,10.21,11,8z M13,8c0,1.1,0.9,2,2,2s2-0.9,2-2c0-1.1-0.9-2-2-2S13,6.9,13,8z M15,15c-2.37,0-4.29,0.73-5.48,1.34 C9.2,16.5,9,16.84,9,17.22V18l7.17,0c0.5,0.86,1.25,1.56,2.15,2L7,20v-2.78c0-1.12,0.61-2.15,1.61-2.66C10.29,13.7,12.47,13,15,13 c0.39,0,0.77,0.02,1.14,0.05c-0.33,0.59-0.55,1.26-0.62,1.96C15.35,15,15.18,15,15,15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
