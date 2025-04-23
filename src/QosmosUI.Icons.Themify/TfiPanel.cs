// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiPanel : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0 0v17h17v-17h-17zM16 16h-15v-15h15v15zM4 10.232v2.768h1v-2.768c0.738-0.218 1.281-0.894 1.281-1.701s-0.543-1.483-1.281-1.701v-2.83h-1v2.83c-0.738 0.218-1.281 0.894-1.281 1.701s0.543 1.484 1.281 1.701zM4.5 7.75c0.431 0 0.781 0.351 0.781 0.781s-0.35 0.781-0.781 0.781-0.781-0.35-0.781-0.781 0.35-0.781 0.781-0.781zM8 8.107v4.893h1v-4.893c0.738-0.218 1.281-0.894 1.281-1.701s-0.543-1.483-1.281-1.701v-0.705h-1v0.705c-0.738 0.218-1.281 0.894-1.281 1.701s0.543 1.484 1.281 1.701zM8.5 5.625c0.431 0 0.781 0.351 0.781 0.781s-0.35 0.782-0.781 0.782-0.781-0.351-0.781-0.782 0.35-0.781 0.781-0.781zM12.5 13.417c0.982 0 1.781-0.799 1.781-1.781 0-0.808-0.543-1.483-1.281-1.701v-5.935h-1v5.935c-0.738 0.218-1.281 0.894-1.281 1.701 0 0.982 0.799 1.781 1.781 1.781zM12.5 10.854c0.431 0 0.781 0.351 0.781 0.781s-0.351 0.781-0.781 0.781-0.781-0.351-0.781-0.781 0.35-0.781 0.781-0.781z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
