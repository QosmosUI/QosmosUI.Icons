// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiWine : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M11.045 0C8.839.03 5.68 1.06 4.915 2.34c.848 3.193 2.025 9.576 4.7 12.09.6.565 1.455.785 2.27 1.768l.193.324c.6 1.676 1.371 3.814.246 5.104-1.833.54-3.08 1.253-2.976 1.78.133.676 2.42.792 5.107.26 2.687-.53 4.759-1.508 4.625-2.183-.11-.554-1.672-.73-3.715-.482-1.884-.885-1.955-3.022-2.226-4.674l.025-.4c.116-.556.689-1.793 1.035-2.393 1.605-2.779.003-8.337-1.203-13.066-.37-.338-1.088-.479-1.951-.467zm1.832 3.674c.208-.002.44.052.705.176 2.759 8.733-.429 11.097-1.217 11.816-2.55-.882-4.278-1.862-6.244-9.312 4.972 2.58 4.744-2.659 6.756-2.68z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
