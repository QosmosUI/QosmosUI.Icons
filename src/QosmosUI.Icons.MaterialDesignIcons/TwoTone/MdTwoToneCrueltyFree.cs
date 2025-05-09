// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneCrueltyFree : ComponentBase
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
		builder.AddAttribute(18, "d", "M16.88,4.03C16.94,4.2,17,4.51,17,5c0,2.84-1.11,5.24-2.07,6.78c-0.38-0.26-0.83-0.48-1.4-0.62 C13.77,6.64,15.97,4.33,16.88,4.03z M7,5c0-0.49,0.06-0.8,0.12-0.97c0.91,0.3,3.11,2.61,3.36,7.13c-0.58,0.14-1.03,0.35-1.4,0.62 C8.11,10.24,7,7.84,7,5z M16,15.77c-0.44-0.36-0.61-0.52-1.3-1.37C13.94,13.45,13.61,13,12,13s-1.94,0.45-2.7,1.4 c-0.69,0.85-0.86,1.01-1.3,1.37c-0.57,0.49-1,1.03-1,1.73C7,18.88,8.12,20,9.5,20c1,0,1.8-0.33,2.22-0.56 C11.3,19.26,11,18.73,11,18.5c0-0.28,0.45-0.5,1-0.5s1,0.22,1,0.5c0,0.23-0.3,0.76-0.72,0.94C12.7,19.67,13.5,20,14.5,20 c1.38,0,2.5-1.12,2.5-2.5C17,16.8,16.57,16.26,16,15.77z M10.5,16.75c-0.28,0-0.5-0.34-0.5-0.75c0-0.41,0.22-0.75,0.5-0.75 S11,15.59,11,16C11,16.41,10.78,16.75,10.5,16.75z M13.5,16.75c-0.28,0-0.5-0.34-0.5-0.75c0-0.41,0.22-0.75,0.5-0.75S14,15.59,14,16 C14,16.41,13.78,16.75,13.5,16.75z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M17,14c-0.24-0.24-0.44-0.49-0.65-0.75C17.51,11.5,19,8.56,19,5c0-1.95-0.74-3-2-3c-1.54,0-3.96,2.06-5,5.97 C10.96,4.06,8.54,2,7,2C5.74,2,5,3.05,5,5c0,3.56,1.49,6.5,2.65,8.25C7.44,13.51,7.24,13.76,7,14c-0.25,0.25-2,1.39-2,3.5 C5,19.98,7.02,22,9.5,22c1.5,0,2.5-0.5,2.5-0.5s1,0.5,2.5,0.5c2.48,0,4.5-2.02,4.5-4.5C19,15.39,17.25,14.25,17,14z M16.88,4.03 C16.94,4.2,17,4.51,17,5c0,2.84-1.11,5.24-2.07,6.78c-0.38-0.26-0.83-0.48-1.4-0.62C13.77,6.64,15.97,4.33,16.88,4.03z M7,5 c0-0.49,0.06-0.8,0.12-0.97c0.91,0.3,3.11,2.61,3.36,7.13c-0.58,0.14-1.03,0.35-1.4,0.62C8.11,10.24,7,7.84,7,5z M14.5,20 c-1,0-1.8-0.33-2.22-0.56C12.7,19.26,13,18.73,13,18.5c0-0.28-0.45-0.5-1-0.5s-1,0.22-1,0.5c0,0.23,0.3,0.76,0.72,0.94 C11.3,19.67,10.5,20,9.5,20C8.12,20,7,18.88,7,17.5c0-0.7,0.43-1.24,1-1.73c0.44-0.36,0.61-0.52,1.3-1.37 c0.76-0.95,1.09-1.4,2.7-1.4s1.94,0.45,2.7,1.4c0.69,0.85,0.86,1.01,1.3,1.37c0.57,0.49,1,1.03,1,1.73C17,18.88,15.88,20,14.5,20z M14,16c0,0.41-0.22,0.75-0.5,0.75S13,16.41,13,16c0-0.41,0.22-0.75,0.5-0.75S14,15.59,14,16z M11,16c0,0.41-0.22,0.75-0.5,0.75 S10,16.41,10,16c0-0.41,0.22-0.75,0.5-0.75S11,15.59,11,16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
