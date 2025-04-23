// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdInterpreterMode : ComponentBase
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
		builder.AddAttribute(18, "d", "M20.5,16.5c-0.83,0-1.5-0.67-1.5-1.5v-2.5c0-0.83,0.67-1.5,1.5-1.5s1.5,0.67,1.5,1.5V15C22,15.83,21.33,16.5,20.5,16.5z M20,20h1c0,0,0-1.54,0-1.54c1.69-0.24,3-1.7,3-3.46h-1c0,1.38-1.12,2.5-2.5,2.5S18,16.38,18,15h-1c0,1.76,1.31,3.22,3,3.46 C20,18.46,20,20,20,20z M9,12c-2.21,0-4-1.79-4-4c0-2.21,1.79-4,4-4c0.47,0,0.92,0.08,1.34,0.23C9.5,5.26,9,6.57,9,8 c0,1.43,0.5,2.74,1.34,3.77C9.92,11.92,9.47,12,9,12z M7.11,13.13C5.79,14.05,5,15.57,5,17.22V20H1v-2.78 c0-1.12,0.61-2.15,1.61-2.66C3.85,13.92,5.37,13.37,7.11,13.13z M11,8c0-2.21,1.79-4,4-4s4,1.79,4,4c0,2.21-1.79,4-4,4 S11,10.21,11,8z M18.32,20c-1.67-0.81-2.82-2.52-2.82-4.5c0-0.89,0.23-1.73,0.64-2.45C15.77,13.02,15.39,13,15,13 c-2.53,0-4.71,0.7-6.39,1.56C7.61,15.07,7,16.1,7,17.22V20L18.32,20z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
