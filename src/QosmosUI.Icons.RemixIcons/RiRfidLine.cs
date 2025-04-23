// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiRfidLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M18.364 18.3641C21.8787 14.8493 21.8787 9.15086 18.364 5.63614L19.7782 4.22192C24.0739 8.51769 24.0739 15.4825 19.7782 19.7783L18.364 18.3641ZM5.63604 5.63614C2.12132 9.15086 2.12132 14.8493 5.63604 18.3641L4.22183 19.7783C-0.0739417 15.4825 -0.0739417 8.51769 4.22183 4.22192L5.63604 5.63614ZM15.5355 15.5355C17.4882 13.5829 17.4882 10.4171 15.5355 8.46445L16.9497 7.05024C19.6834 9.78391 19.6834 14.2161 16.9497 16.9497L15.5355 15.5355ZM8.46447 8.46445C6.51184 10.4171 6.51184 13.5829 8.46447 15.5355L7.05025 16.9497C4.31658 14.2161 4.31658 9.78391 7.05025 7.05024L8.46447 8.46445ZM12 14.0001C13.1046 14.0001 14 13.1046 14 12.0001C14 10.8955 13.1046 10.0001 12 10.0001C10.8954 10.0001 10 10.8955 10 12.0001C10 13.1046 10.8954 14.0001 12 14.0001Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
