// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlRedbubble : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.002 2.005 12 2.004c-5.52 0-9.996 4.475-9.996 9.995 0 5.521 4.477 9.998 9.996 9.998 5.521 0 9.996-4.475 9.996-9.997 0-5.52-4.475-9.995-9.994-9.995zm.162 13.53a.267.267 0 0 1-.174.066v.001H6.455a.268.268 0 0 1-.266-.268V8.646c0-.148.119-.268.266-.268h2.589c1.612 0 2.576.87 2.576 2.327 0 .969-.486 1.729-1.272 2.039l1.842 2.413a.269.269 0 0 1-.026.378zm3.695.068h-2.665a.268.268 0 0 1-.266-.269V8.646c0-.148.119-.267.266-.267h2.472c1.853 0 2.242 1.091 2.242 2.007 0 .529-.141.949-.421 1.258.681.28 1.047.913 1.047 1.827 0 1.335-1.001 2.132-2.675 2.132z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
