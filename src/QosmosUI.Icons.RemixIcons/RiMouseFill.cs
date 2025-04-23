// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiMouseFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.1411 2H12.8589C14.8728 2 15.9528 2.27848 16.9305 2.8014C17.9083 3.32432 18.6757 4.09169 19.1986 5.06946C19.7215 6.04724 20 7.12721 20 9.14111V14.8589C20 16.8728 19.7215 17.9528 19.1986 18.9305C18.6757 19.9083 17.9083 20.6757 16.9305 21.1986C15.9528 21.7215 14.8728 22 12.8589 22H11.1411C9.12721 22 8.04724 21.7215 7.06946 21.1986C6.09169 20.6757 5.32432 19.9083 4.8014 18.9305C4.27848 17.9528 4 16.8728 4 14.8589V9.14111C4 7.12721 4.27848 6.04724 4.8014 5.06946C5.32432 4.09169 6.09169 3.32432 7.06946 2.8014C8.04724 2.27848 9.12721 2 11.1411 2ZM11 6V11H13V6H11Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
