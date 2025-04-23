// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundLunchDining : ComponentBase
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
		builder.AddAttribute(21, "d", "M3.37,14.28c0.79-0.29,1.17-0.78,1.99-0.78c1.19,0,1.42,1,3.33,1c1.95,0,2.09-1,3.33-1c1.19,0,1.42,1,3.33,1 c1.95,0,2.09-1,3.33-1c0.81,0,1.17,0.46,1.93,0.76c0.67,0.26,1.39-0.25,1.39-0.96c0-0.43-0.28-0.81-0.69-0.96 c-0.97-0.35-1.22-0.83-2.65-0.83c-1.95,0-2.09,1-3.33,1c-1.19,0-1.42-1-3.33-1c-1.95,0-2.09,1-3.33,1c-1.19,0-1.42-1-3.33-1 c-1.55,0-1.96,0.63-2.68,0.89c-0.39,0.14-0.65,0.52-0.65,0.94C2.01,14.03,2.71,14.52,3.37,14.28z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M2,19c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2v-1c0-1.1-0.9-2-2-2H4c-1.1,0-2,0.9-2,2V19z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M22,9c0.02-4-4.28-6-10-6C6.29,3,2,5,2,9v0c0,0.55,0.45,1,1,1h18C21.55,10,22,9.55,22,9L22,9L22,9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
