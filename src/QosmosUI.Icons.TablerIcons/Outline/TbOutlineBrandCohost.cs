// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Outline;

public class TbOutlineBrandCohost : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M17 14m-3 0a3 2 0 1 0 6 0a3 2 0 1 0 -6 0");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M4.526 17.666c-1.133 -.772 -1.897 -1.924 -2.291 -3.456c-.398 -1.54 -.29 -2.937 .32 -4.19c.61 -1.255 1.59 -2.34 2.938 -3.254c1.348 -.914 2.93 -1.625 4.749 -2.132c1.81 -.504 3.516 -.708 5.12 -.61c1.608 .1 2.979 .537 4.112 1.31s1.897 1.924 2.291 3.456c.398 1.541 .29 2.938 -.32 4.192c-.61 1.253 -1.59 2.337 -2.938 3.252c-1.348 .915 -2.93 1.626 -4.749 2.133c-1.81 .503 -3.516 .707 -5.12 .61c-1.608 -.102 -2.979 -.538 -4.112 -1.31z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M11 12.508c-.53 -.316 -1.23 -.508 -2 -.508c-1.657 0 -3 .895 -3 2s1.343 2 3 2c.767 0 1.467 -.192 2 -.508");
		builder.CloseElement();
		builder.CloseElement();
    }
}
