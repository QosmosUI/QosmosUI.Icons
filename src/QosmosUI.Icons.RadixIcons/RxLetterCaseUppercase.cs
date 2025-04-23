// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxLetterCaseUppercase : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M3.6255 2.75C3.83478 2.75 4.02192 2.88034 4.09448 3.07664L7.16985 11.3962C7.2656 11.6552 7.13324 11.9428 6.87423 12.0386C6.61522 12.1343 6.32763 12.002 6.23188 11.7429L5.22387 9.01603H2.02712L1.01911 11.7429C0.923362 12.002 0.635774 12.1343 0.376762 12.0386C0.117749 11.9428 -0.0146052 11.6552 0.0811401 11.3962L3.15651 3.07664C3.22908 2.88034 3.41621 2.75 3.6255 2.75ZM3.6255 4.69207L4.90966 8.16603H2.34133L3.6255 4.69207ZM11.3719 2.75C11.5811 2.75 11.7683 2.88034 11.8408 3.07664L14.9162 11.3962C15.012 11.6552 14.8796 11.9428 14.6206 12.0386C14.3616 12.1343 14.074 12.002 13.9782 11.7429L12.9702 9.01603H9.77348L8.76547 11.7429C8.66972 12.002 8.38213 12.1343 8.12312 12.0386C7.86411 11.9428 7.73175 11.6552 7.8275 11.3962L10.9029 3.07664C10.9754 2.88034 11.1626 2.75 11.3719 2.75ZM11.3719 4.69207L12.656 8.16603H10.0877L11.3719 4.69207Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
