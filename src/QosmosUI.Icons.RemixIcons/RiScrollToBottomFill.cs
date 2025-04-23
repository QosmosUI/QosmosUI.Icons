// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiScrollToBottomFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.8589 2H11.1411C9.12721 2 8.04724 2.27848 7.06946 2.8014C6.09169 3.32432 5.32432 4.09169 4.8014 5.06946C4.27848 6.04724 4 7.12721 4 9.14111V14.8589C4 16.8728 4.27848 17.9528 4.8014 18.9305C5.32432 19.9083 6.09169 20.6757 7.06946 21.1986C8.04724 21.7215 9.12721 22 11.1411 22H12.8589C14.8728 22 15.9528 21.7215 16.9305 21.1986C17.9083 20.6757 18.6757 19.9083 19.1986 18.9305C19.7215 17.9528 20 16.8728 20 14.8589V9.14111C20 7.12721 19.7215 6.04724 19.1986 5.06946C18.6757 4.09169 17.9083 3.32432 16.9305 2.8014C15.9528 2.27848 14.8728 2 12.8589 2ZM11 11V6H13V11H11ZM7.75781 13.758L9.17203 12.3438L12.0005 15.1722L14.8289 12.3438L16.2431 13.758L12.0005 18.0006L7.75781 13.758Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
