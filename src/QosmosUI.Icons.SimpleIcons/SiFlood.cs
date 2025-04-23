// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiFlood : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M19.683 16.283c-1.233-.066-1.85-1.533-2.15-2.433-.266-.767-.666-2.117-.966-2.933-.35-.95-.45-1.017-.65-1.017-.417 0-.734 1.183-1.05 2.067-.667 1.833-1.167 3.85-2.934 3.85-1.533 0-2.216-1.184-2.7-1.884-.45-.666-.716-.816-1.133-.816-.533 0-.783.466-1.267 1.283-.283.467-.6.95-.966 1.267-.1.083-.934.733-1.717.633-.45-.067-.767-.333-.767-.783 0-.617.684-.734 1.067-.884.333-.116.733-.716.933-1.05.534-.916 1.217-2.116 2.75-2.116 1.35 0 2 .866 2.5 1.55.45.616.717 1.116 1.234 1.133.433.017 1.033-1.617 1.383-2.75.533-1.733 1.233-3.333 2.633-3.333 1.884 0 2.434 2.633 3.017 4.65.083.3.283.933.333 1.016.267.567.484.934.717 1.05.267.15.7.434.567.934-.084.383-.434.583-.834.566zm-15.366-1.6c.016 0 .016 0 0 0 .016 0 .016 0 0 0zM12 0C5.367 0 0 5.367 0 12s5.367 12 12 12 12-5.367 12-12S18.633 0 12 0zm0 22.017A10.015 10.015 0 011.983 12 10.015 10.015 0 0112 1.983 10.015 10.015 0 0122.017 12 10.015 10.015 0 0112 22.017Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
