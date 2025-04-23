// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineDraw : ComponentBase
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
		builder.AddAttribute(18, "d", "M18.85,10.39l1.06-1.06c0.78-0.78,0.78-2.05,0-2.83L18.5,5.09c-0.78-0.78-2.05-0.78-2.83,0l-1.06,1.06L18.85,10.39z M14.61,11.81L7.41,19H6v-1.41l7.19-7.19L14.61,11.81z M13.19,7.56L4,16.76V21h4.24l9.19-9.19L13.19,7.56L13.19,7.56z M19,17.5 c0,2.19-2.54,3.5-5,3.5c-0.55,0-1-0.45-1-1s0.45-1,1-1c1.54,0,3-0.73,3-1.5c0-0.47-0.48-0.87-1.23-1.2l1.48-1.48 C18.32,15.45,19,16.29,19,17.5z M4.58,13.35C3.61,12.79,3,12.06,3,11c0-1.8,1.89-2.63,3.56-3.36C7.59,7.18,9,6.56,9,6 c0-0.41-0.78-1-2-1C5.74,5,5.2,5.61,5.17,5.64C4.82,6.05,4.19,6.1,3.77,5.76C3.36,5.42,3.28,4.81,3.62,4.38C3.73,4.24,4.76,3,7,3 c2.24,0,4,1.32,4,3c0,1.87-1.93,2.72-3.64,3.47C6.42,9.88,5,10.5,5,11c0,0.31,0.43,0.6,1.07,0.86L4.58,13.35z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
