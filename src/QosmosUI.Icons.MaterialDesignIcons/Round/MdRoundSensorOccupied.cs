// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSensorOccupied : ComponentBase
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
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,11c1.66,0,3-1.34,3-3s-1.34-3-3-3S9,6.34,9,8S10.34,11,12,11z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,12c-1.84,0-3.56,0.5-5.03,1.37C6.36,13.73,6,14.39,6,15.09L6,16c0,0.55,0.45,1,1,1h10c0.55,0,1-0.45,1-1l0-0.91 c0-0.7-0.36-1.36-0.97-1.72C15.56,12.5,13.84,12,12,12z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M22.11,7.79L22.11,7.79c0.55-0.23,0.78-0.88,0.5-1.41c-1.13-2.12-2.87-3.86-4.99-4.99c-0.52-0.28-1.17-0.04-1.4,0.5v0 c-0.19,0.47-0.01,1.02,0.43,1.25c1.79,0.94,3.26,2.42,4.21,4.21C21.09,7.8,21.64,7.98,22.11,7.79z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M7.79,1.89L7.79,1.89c-0.23-0.55-0.88-0.78-1.4-0.5C4.27,2.52,2.52,4.26,1.4,6.38c-0.28,0.52-0.05,1.18,0.5,1.41l0,0 c0.47,0.2,1.02,0.01,1.25-0.43c0.94-1.79,2.42-3.26,4.21-4.21C7.8,2.91,7.98,2.36,7.79,1.89z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M1.89,16.21L1.89,16.21c-0.55,0.23-0.78,0.88-0.5,1.4c1.13,2.12,2.87,3.87,5,5c0.52,0.28,1.17,0.04,1.4-0.5l0,0 c0.19-0.47,0.01-1.02-0.43-1.25c-1.79-0.94-3.26-2.42-4.21-4.21C2.91,16.2,2.36,16.02,1.89,16.21z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M16.21,22.11L16.21,22.11c0.23,0.55,0.88,0.78,1.4,0.5c2.12-1.13,3.87-2.87,5-5c0.28-0.52,0.04-1.17-0.5-1.4h0 c-0.47-0.19-1.02-0.01-1.25,0.43c-0.94,1.79-2.42,3.26-4.21,4.21C16.2,21.09,16.02,21.64,16.21,22.11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
