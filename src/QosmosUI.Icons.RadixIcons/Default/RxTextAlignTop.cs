// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxTextAlignTop : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

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
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M3.89949 9.49998C3.89949 9.72089 3.7204 9.89997 3.49949 9.89997C3.27857 9.89997 3.09949 9.72089 3.09949 9.49998L3.09949 2.46566L1.78233 3.78282C1.62612 3.93903 1.37285 3.93903 1.21664 3.78282C1.06043 3.62661 1.06043 3.37334 1.21664 3.21713L3.21664 1.21713C3.29166 1.14212 3.3934 1.09998 3.49949 1.09998C3.60557 1.09998 3.70732 1.14212 3.78233 1.21713L5.78233 3.21713C5.93854 3.37334 5.93854 3.62661 5.78233 3.78282C5.62612 3.93903 5.37285 3.93903 5.21664 3.78282L3.89949 2.46566L3.89949 9.49998ZM8.49998 1.99998C8.22383 1.99998 7.99998 2.22383 7.99998 2.49998C7.99998 2.77612 8.22383 2.99998 8.49998 2.99998H14.5C14.7761 2.99998 15 2.77612 15 2.49998C15 2.22383 14.7761 1.99998 14.5 1.99998H8.49998ZM8.49998 4.99998C8.22383 4.99998 7.99998 5.22383 7.99998 5.49998C7.99998 5.77612 8.22383 5.99998 8.49998 5.99998H14.5C14.7761 5.99998 15 5.77612 15 5.49998C15 5.22383 14.7761 4.99998 14.5 4.99998H8.49998ZM7.99998 8.49998C7.99998 8.22383 8.22383 7.99998 8.49998 7.99998H14.5C14.7761 7.99998 15 8.22383 15 8.49998C15 8.77612 14.7761 8.99998 14.5 8.99998H8.49998C8.22383 8.99998 7.99998 8.77612 7.99998 8.49998Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
