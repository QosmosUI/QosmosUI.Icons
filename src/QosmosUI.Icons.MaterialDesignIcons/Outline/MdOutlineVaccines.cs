// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineVaccines : ComponentBase
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
		builder.AddAttribute(18, "d", "M11,5.5H8V4h0.5c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1h-3c-0.55,0-1,0.45-1,1c0,0.55,0.45,1,1,1H6v1.5H3c-0.55,0-1,0.45-1,1 c0,0.55,0.45,1,1,1V15c0,1.1,0.9,2,2,2h1v4l2,1.5V17h1c1.1,0,2-0.9,2-2V7.5c0.55,0,1-0.45,1-1C12,5.95,11.55,5.5,11,5.5z M9,9H7.25 C6.84,9,6.5,9.34,6.5,9.75c0,0.41,0.34,0.75,0.75,0.75H9V12H7.25c-0.41,0-0.75,0.34-0.75,0.75c0,0.41,0.34,0.75,0.75,0.75H9L9,15H5 V7.5h4V9z M19.5,10.5V10c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1h-5c-0.55,0-1,0.45-1,1c0,0.55,0.45,1,1,1v0.5c0,0.5-1.5,1.16-1.5,3V20 c0,1.1,0.9,2,2,2h4c1.1,0,2-0.9,2-2v-6.5C21,11.66,19.5,11,19.5,10.5z M16.5,10.5V10h1v0.5c0,1.6,1.5,2,1.5,3V14h-4 c0-0.21,0-0.39,0-0.5C15,12.5,16.5,12.1,16.5,10.5z M19,15.5V17h-4c0-0.51,0-1.02,0-1.5H19z M15,20c0,0,0-0.63,0-1.5h4V20H15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
