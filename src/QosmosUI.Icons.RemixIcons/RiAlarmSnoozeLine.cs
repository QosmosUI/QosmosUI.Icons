// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiAlarmSnoozeLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M3.00012 13.0001C3.00012 17.9707 7.02956 22.0001 12.0001 22.0001C16.9707 22.0001 21.0001 17.9707 21.0001 13.0001C21.0001 8.02956 16.9707 4.00012 12.0001 4.00012C7.02956 4.00012 3.00012 8.02956 3.00012 13.0001ZM19.0001 13.0001C19.0001 16.8661 15.8661 20.0001 12.0001 20.0001C8.13412 20.0001 5.00012 16.8661 5.00012 13.0001C5.00012 9.13412 8.13412 6.00012 12.0001 6.00012C15.8661 6.00012 19.0001 9.13412 19.0001 13.0001ZM5.2826 2.74707L1.74707 6.2826L3.16128 7.69682L6.69682 4.16128L5.2826 2.74707ZM22.2532 6.2826L18.7176 2.74707L17.3034 4.16128L20.839 7.69682L22.2532 6.2826ZM9 11H12.5858L9 14.5858V17H15V15H11.4142L15 11.4142V9H9V11Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
