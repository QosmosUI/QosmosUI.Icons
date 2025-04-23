// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiServiceFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M14.1213 10.4792C13.7308 10.0886 13.0976 10.0886 12.7071 10.4792L12 11.1863C11.2189 11.9673 9.95259 11.9673 9.17154 11.1863C8.39049 10.4052 8.39049 9.13888 9.17154 8.35783L14.8022 2.72568C16.9061 2.24973 19.2008 2.83075 20.8388 4.46875C23.2582 6.88811 23.3716 10.7402 21.1792 13.2939L19.071 15.4289L14.1213 10.4792ZM3.16113 4.46875C5.33452 2.29536 8.66411 1.98283 11.17 3.53116L7.75732 6.94362C6.19523 8.50572 6.19523 11.0384 7.75732 12.6005C9.27209 14.1152 11.6995 14.1611 13.2695 12.7382L13.4142 12.6005L17.6568 16.8431L13.4142 21.0858C12.6331 21.8668 11.3668 21.8668 10.5858 21.0858L3.16113 13.6611C0.622722 11.1227 0.622722 7.00715 3.16113 4.46875Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
