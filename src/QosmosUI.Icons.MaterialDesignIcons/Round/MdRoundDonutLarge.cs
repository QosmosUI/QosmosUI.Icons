// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDonutLarge : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M14.07 5.32C16.26 6 18 7.74 18.68 9.93c.19.63.76 1.07 1.41 1.07h.04c1 0 1.72-.96 1.43-1.91-.97-3.18-3.48-5.69-6.66-6.66-.94-.29-1.9.43-1.9 1.43v.04c0 .66.44 1.23 1.07 1.42zm4.61 8.75c-.68 2.2-2.42 3.93-4.61 4.61-.63.19-1.07.76-1.07 1.41v.04c0 1 .96 1.72 1.91 1.43 3.18-.97 5.69-3.48 6.66-6.66.29-.95-.43-1.91-1.42-1.91h-.05c-.66.01-1.23.45-1.42 1.08zM11 20.11c0-.67-.45-1.24-1.09-1.44C7.07 17.78 5 15.13 5 12s2.07-5.78 4.91-6.67c.64-.2 1.09-.77 1.09-1.44v-.01c0-1-.97-1.74-1.93-1.44C4.98 3.69 2 7.5 2 12c0 4.5 2.98 8.31 7.07 9.56.96.3 1.93-.44 1.93-1.45z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
