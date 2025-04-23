// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneChangeCircle : ComponentBase
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
		builder.AddAttribute(18, "d", "M12,4c4.41,0,8,3.59,8,8s-3.59,8-8,8s-8-3.59-8-8S7.59,4,12,4 M12.06,13.34v2.14 c-0.92,0.02-1.84-0.31-2.54-1.01c-1.12-1.12-1.3-2.8-0.59-4.13l-1.1-1.1c-1.28,1.94-1.07,4.59,0.64,6.29C9.44,16.51,10.72,17,12,17 c0.02,0,0.04,0,0.06,0V19l2.83-2.83L12.06,13.34z M15.54,8.46c-0.99-0.99-2.3-1.46-3.6-1.45V5L9.11,7.83l2.83,2.83V8.51 c0.02,0,0.04,0,0.06,0c0.9,0,1.79,0.34,2.48,1.02c1.12,1.12,1.3,2.8,0.59,4.13l1.1,1.1C17.45,12.82,17.24,10.17,15.54,8.46z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M12,4c4.41,0,8,3.59,8,8s-3.59,8-8,8s-8-3.59-8-8S7.59,4,12,4 M12,2C6.48,2,2,6.48,2,12s4.48,10,10,10s10-4.48,10-10 S17.52,2,12,2L12,2z M12.06,13.34v2.14c-0.92,0.02-1.84-0.31-2.54-1.01c-1.12-1.12-1.3-2.8-0.59-4.13l-1.1-1.1 c-1.28,1.94-1.07,4.59,0.64,6.29C9.44,16.51,10.72,17,12,17c0.02,0,0.04,0,0.06,0V19l2.83-2.83L12.06,13.34z M15.54,8.46 c-0.99-0.99-2.3-1.46-3.6-1.45V5L9.11,7.83l2.83,2.83V8.51c0.02,0,0.04,0,0.06,0c0.9,0,1.79,0.34,2.48,1.02 c1.12,1.12,1.3,2.8,0.59,4.13l1.1,1.1C17.45,12.82,17.24,10.17,15.54,8.46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
