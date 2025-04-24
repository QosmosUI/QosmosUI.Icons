// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoFootstepsOutline : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M200,246.84c8.81,58.62-7.33,90.67-52.91,97.41-50.65,7.49-71.52-26.44-80.33-85.06-11.85-78.88,16-127.94,55.71-131.1C158.61,125.22,191.18,188.23,200,246.84Z");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "stroke-miterlimit", "10");
		builder.AddAttribute(17, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M223.65,409.53c3.13,33.28-14.86,64.34-42,69.66-27.4,5.36-58.71-16.37-65.09-49.19s17.75-34.56,47.32-40.21S219.87,369.39,223.65,409.53Z");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-miterlimit", "10");
		builder.AddAttribute(22, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M312,150.83c-8.81,58.62,7.33,90.67,52.9,97.41,50.66,7.49,71.52-26.44,80.33-85.06,11.86-78.89-16-128.22-55.7-131.1C353.13,29.44,320.82,92.21,312,150.83Z");
		builder.AddAttribute(25, "fill", "none");
		builder.AddAttribute(26, "stroke-miterlimit", "10");
		builder.AddAttribute(27, "stroke-width", "32");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M288.35,313.53c-3.13,33.27,14.86,64.34,42,69.66,27.4,5.36,58.71-16.37,65.09-49.19s-17.75-34.56-47.32-40.22S292.13,273.38,288.35,313.53Z");
		builder.AddAttribute(30, "fill", "none");
		builder.AddAttribute(31, "stroke-miterlimit", "10");
		builder.AddAttribute(32, "stroke-width", "32");
		builder.CloseElement();
		builder.CloseElement();
    }
}
