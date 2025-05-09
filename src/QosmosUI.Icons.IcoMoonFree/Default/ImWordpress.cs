// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImWordpress : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M2 8c0 2.313 1.38 4.312 3.382 5.259l-2.862-7.637c-0.333 0.727-0.52 1.531-0.52 2.378zM12.050 7.705c0-0.722-0.266-1.222-0.495-1.612-0.304-0.482-0.589-0.889-0.589-1.371 0-0.537 0.418-1.037 1.008-1.037 0.027 0 0.052 0.003 0.078 0.005-1.067-0.953-2.49-1.534-4.052-1.534-2.096 0-3.94 1.048-5.013 2.634 0.141 0.004 0.274 0.007 0.386 0.007 0.627 0 1.599-0.074 1.599-0.074 0.323-0.018 0.361 0.444 0.038 0.482 0 0-0.325 0.037-0.687 0.055l2.185 6.33 1.313-3.835-0.935-2.495c-0.323-0.019-0.629-0.055-0.629-0.055-0.323-0.019-0.285-0.5 0.038-0.482 0 0 0.991 0.074 1.58 0.074 0.627 0 1.599-0.074 1.599-0.074 0.323-0.018 0.362 0.444 0.038 0.482 0 0-0.326 0.037-0.687 0.055l2.168 6.282 0.599-1.947c0.259-0.809 0.457-1.389 0.457-1.889zM8.105 8.511l-1.8 5.095c0.538 0.154 1.106 0.238 1.695 0.238 0.699 0 1.369-0.117 1.992-0.331-0.016-0.025-0.031-0.052-0.043-0.081l-1.844-4.921zM13.265 5.196c0.026 0.186 0.040 0.386 0.040 0.601 0 0.593-0.114 1.259-0.456 2.093l-1.833 5.16c1.784-1.013 2.983-2.895 2.983-5.051 0-1.016-0.267-1.971-0.735-2.803zM8 0c-4.418 0-8 3.582-8 8s3.582 8 8 8 8-3.582 8-8-3.582-8-8-8zM8 15c-3.866 0-7-3.134-7-7s3.134-7 7-7 7 3.134 7 7-3.134 7-7 7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
