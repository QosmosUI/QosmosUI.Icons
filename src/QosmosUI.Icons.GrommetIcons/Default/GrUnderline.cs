// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrUnderline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M14.41,4.53V4.18h4.66v.36h-.49a1.34,1.34,0,0,0-1.19.65,3,3,0,0,0-.2,1.4v5.33A9.45,9.45,0,0,1,16.78,15a3.85,3.85,0,0,1-1.54,1.87,5.49,5.49,0,0,1-3.13.78,5.89,5.89,0,0,1-3.27-.75,4,4,0,0,1-1.58-2A11.14,11.14,0,0,1,7,11.64V6.5a2.58,2.58,0,0,0-.33-1.59,1.38,1.38,0,0,0-1.08-.38H5V4.18h5.68v.36h-.5A1.3,1.3,0,0,0,9.06,5,2.87,2.87,0,0,0,8.81,6.5v5.73A12.52,12.52,0,0,0,9,14a3.71,3.71,0,0,0,.51,1.54,2.77,2.77,0,0,0,1.06.91,3.68,3.68,0,0,0,1.7.36,4.69,4.69,0,0,0,2.31-.56,3,3,0,0,0,1.39-1.44,8.33,8.33,0,0,0,.37-3V6.5A2.72,2.72,0,0,0,16,5a1.43,1.43,0,0,0-1.12-.43Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M4.93,20V19H19v1Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
