// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundEmergencyShare : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M12,9c-3.15,0-6,2.41-6,6.15c0,2.35,1.78,5.11,5.34,8.27c0.37,0.33,0.95,0.33,1.33,0C16.22,20.25,18,17.5,18,15.15 C18,11.41,15.15,9,12,9z M12,16.5c-0.83,0-1.5-0.67-1.5-1.5s0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5S12.83,16.5,12,16.5z M16.18,6.82 c-0.35,0.35-0.89,0.38-1.3,0.09C14.07,6.34,13.07,6,12,6S9.93,6.34,9.12,6.91c-0.41,0.28-0.95,0.26-1.3-0.09 c-0.43-0.43-0.39-1.15,0.09-1.5C9.06,4.49,10.48,4,12,4s2.94,0.49,4.09,1.32C16.58,5.67,16.61,6.39,16.18,6.82z M4.97,3.97 C4.55,3.54,4.59,2.85,5.05,2.47C6.95,0.93,9.37,0,12.01,0c2.64,0,5.06,0.93,6.95,2.48c0.46,0.38,0.5,1.07,0.08,1.49 c-0.36,0.36-0.93,0.39-1.32,0.07C16.16,2.77,14.17,2,12.01,2C9.83,2,7.84,2.77,6.29,4.04C5.9,4.36,5.33,4.32,4.97,3.97z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
