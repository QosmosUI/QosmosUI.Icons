// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Outline;

public class TbOutlineSpiralOff : ComponentBase
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
    public string StrokeWidth { get; set; } = "2";

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
		builder.AddAttribute(14, "d", "M10 12.057a1.9 1.9 0 0 0 .614 .743c.682 .459 1.509 .374 2.164 -.02m1.103 -2.92a3.298 3.298 0 0 0 -1.749 -2.059a3.6 3.6 0 0 0 -.507 -.195m-3.385 .634a4.154 4.154 0 0 0 -1.347 1.646c-1.095 2.432 .29 5.248 2.71 6.246c1.955 .806 4.097 .35 5.65 -.884m1.745 -2.268l.043 -.103c1.36 -3.343 -.557 -7.134 -3.896 -8.41c-1.593 -.61 -3.27 -.599 -4.79 -.113m-2.579 1.408a7.574 7.574 0 0 0 -2.268 3.128c-1.63 4.253 .823 9.024 5.082 10.576c3.211 1.17 6.676 .342 9.124 -1.738m1.869 -2.149a9.354 9.354 0 0 0 1.417 -4.516");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M3 3l18 18");
		builder.CloseElement();
		builder.CloseElement();
    }
}
