// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundModeOfTravel : ComponentBase
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
		builder.AddAttribute(18, "d", "M4,10.2C4,5.22,7.8,2,12,2c4,0,7.64,2.92,7.97,7.5l2.32,0c0.45,0,0.67,0.54,0.35,0.85l-3.29,3.29c-0.2,0.2-0.51,0.2-0.71,0 l-3.29-3.29c-0.31-0.31-0.09-0.85,0.35-0.85l2.26,0C17.65,6.24,15.13,4,12,4c-3.35,0-6,2.57-6,6.2c0,2.34,1.95,5.44,6,9.14 c0.64-0.59,1.23-1.16,1.77-1.71c-0.17-0.34-0.27-0.72-0.27-1.12c0-1.38,1.12-2.5,2.5-2.5s2.5,1.12,2.5,2.5S17.38,19,16,19 c-0.24,0-0.47-0.03-0.69-0.1c-0.78,0.82-1.67,1.66-2.65,2.52c-0.38,0.33-0.95,0.33-1.33,0C6.45,17.12,4,13.38,4,10.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
