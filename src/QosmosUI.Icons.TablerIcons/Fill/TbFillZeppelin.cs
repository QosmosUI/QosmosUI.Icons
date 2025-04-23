// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillZeppelin : ComponentBase
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
		builder.AddAttribute(14, "d", "M13.5 3c5.187 0 9.5 3.044 9.5 7c0 3.017 -2.508 5.503 -6 6.514v3.486a1 1 0 0 1 -1 1h-6a1 1 0 0 1 -1 -1v-4.046a21 21 0 0 1 -2.66 -1.411l-.13 -.082l-1.57 1.308a1 1 0 0 1 -1.634 -.656l-.006 -.113v-2.851l-.31 -.25a47 47 0 0 1 -.682 -.568l-.67 -.582a1 1 0 0 1 0 -1.498a47 47 0 0 1 1.351 -1.151l.311 -.25v-2.85a1 1 0 0 1 1.55 -.836l.09 .068l1.57 1.307l.128 -.08c2.504 -1.553 4.784 -2.378 6.853 -2.453zm-2.499 13.657l-.001 2.343h4l.001 -2.086q -.735 .086 -1.501 .086a9.6 9.6 0 0 1 -2.13 -.252z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
