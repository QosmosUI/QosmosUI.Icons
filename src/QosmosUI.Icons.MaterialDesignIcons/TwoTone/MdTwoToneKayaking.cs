// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneKayaking : ComponentBase
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
		builder.AddAttribute(18, "d", "M21,23c-1.03,0-2.06-0.25-3-0.75h0c-1.89,1-4.11,1-6,0c-1.89,1-4.11,1-6,0C5.05,22.75,4.03,23,3,23H2l0-2h1 c1.04,0,2.08-0.35,3-1c1.83,1.3,4.17,1.3,6,0c1.83,1.3,4.17,1.3,6,0c0.91,0.65,1.96,1,3,1h1v2H21z M12,5.5c-1.1,0-2,0.9-2,2 s0.9,2,2,2s2-0.9,2-2S13.1,5.5,12,5.5z M24,17.5c0,0-1.52,0.71-3.93,1.37c-0.82-0.23-1.53-0.75-2.07-1.37c-0.73,0.84-1.8,1.5-3,1.5 s-2.27-0.66-3-1.5c-0.73,0.84-1.8,1.5-3,1.5s-2.27-0.66-3-1.5c-0.54,0.61-1.25,1.13-2.07,1.37C1.52,18.21,0,17.5,0,17.5 s2.93-1.36,7.13-2.08l1.35-4.17c0.31-0.95,1.32-1.47,2.27-1.16c0.09,0.03,0.19,0.07,0.27,0.11l0,0l2.47,1.3l2.84-1.5l1.65-3.71 l-0.51-1.32L18.8,2L22,3.43L20.67,6.4l-1.31,0.5l-3.72,8.34C20.49,15.87,24,17.5,24,17.5z M15.02,12.96l-1.52,0.8l-1.75-0.92 l-0.71,2.17C11.36,15.01,11.68,15,12,15c0.71,0,1.4,0.03,2.07,0.08L15.02,12.96z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
