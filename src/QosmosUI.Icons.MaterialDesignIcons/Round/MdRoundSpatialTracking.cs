// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSpatialTracking : ComponentBase
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
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "10");
		builder.AddAttribute(26, "cy", "9");
		builder.AddAttribute(27, "r", "4");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M16.39,15.56C14.71,14.7,12.53,14,10,14c-2.53,0-4.71,0.7-6.39,1.56C2.61,16.07,2,17.1,2,18.22V21h16v-2.78 C18,17.1,17.39,16.07,16.39,15.56z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M19.39,1.76L19.39,1.76c-0.43-0.43-1.14-0.39-1.51,0.09c-1.5,1.93-3.35,6.72,0,11.03c0.37,0.48,1.08,0.52,1.5,0.09l0,0 c0.35-0.35,0.39-0.91,0.09-1.3c-1.17-1.5-2.64-5.23,0-8.61C19.78,2.67,19.74,2.11,19.39,1.76z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M22.4,5.86c0.23-0.4,0.19-0.9-0.14-1.22l0,0C21.79,4.16,21,4.27,20.67,4.85c-1.15,2-0.57,4.03,0.01,5.04 c0.33,0.57,1.11,0.67,1.58,0.21c0.33-0.33,0.36-0.84,0.13-1.25C22.14,8.41,21.65,7.16,22.4,5.86z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
