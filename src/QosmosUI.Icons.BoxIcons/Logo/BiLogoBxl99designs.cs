// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxl99designs : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.93 10.61A2.7 2.7 0 0 0 19 10a2.74 2.74 0 0 0-1.1-.19 3.28 3.28 0 0 0-2.16.76v-.05a3.67 3.67 0 0 0-5.09-3.39 3.61 3.61 0 0 0-1.78 1.56 3.67 3.67 0 0 0-3.12-1.86 3.74 3.74 0 0 0-1.82.44 3.66 3.66 0 0 0-1.37 1.28A3.77 3.77 0 0 0 2 10.34a3.67 3.67 0 0 0 3.42 3.83l-1.6 2.76h2.39l2.65-4.59a3.63 3.63 0 0 0 2.93 1.84l-1.59 2.76h2.4l1.86-3.23a3.53 3.53 0 0 0 2.07 3.19 3.52 3.52 0 0 0 2.61.05 2.58 2.58 0 0 0 .9-.74v.73h2V7.06h-2.11zm-12.78.72a1.69 1.69 0 0 1-1.46.83 1.72 1.72 0 0 1-.86-.16 1.75 1.75 0 0 1-.62-.62 1.78 1.78 0 0 1-.21-.87 1.69 1.69 0 0 1 1.67-1.69 1.63 1.63 0 0 1 .84.23 1.58 1.58 0 0 1 .62.61 1.62 1.62 0 0 1 .23.83 1.72 1.72 0 0 1-.21.84zm6.38 0a1.58 1.58 0 0 1-.62.61 1.53 1.53 0 0 1-.84.22 1.78 1.78 0 0 1-.84-.22 1.65 1.65 0 0 1-.61-.62 1.67 1.67 0 0 1 0-1.69 1.73 1.73 0 0 1 .62-.61 1.63 1.63 0 0 1 .84-.23 1.69 1.69 0 0 1 .84.23 1.69 1.69 0 0 1 .63 2.28zm6.3 3a1.72 1.72 0 0 1-2 .85 1.72 1.72 0 0 1-1-.7 1.75 1.75 0 0 1-.29-1.15 1.77 1.77 0 0 1 .51-1.07 1.75 1.75 0 0 1 2.35-.11 1.73 1.73 0 0 1 .43 2.18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
