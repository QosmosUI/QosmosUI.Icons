// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiRocket2Line : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.5018 20.0048C14.8432 21.5841 13.5794 22.848 12 23.5066C10.4206 22.848 9.15679 21.5841 8.49816 20.0048H10.7575C11.0838 20.4934 11.5051 20.9171 12 21.248C12.4949 20.9171 12.9162 20.4934 13.2425 20.0048H15.5018ZM18 14.8095L20 17.0777V19.0048H4V17.0777L6 14.8095V9.00478C6 5.52153 8.50442 2.55822 12 1.45999C15.4956 2.55822 18 5.52153 18 9.00478V14.8095ZM17.2692 17.0048L16 15.5653V9.00478C16 6.68694 14.4292 4.57431 12 3.58384C9.57078 4.57431 8 6.68694 8 9.00478V15.5653L6.73076 17.0048H17.2692ZM12 11.0048C10.8954 11.0048 10 10.1093 10 9.00478C10 7.90021 10.8954 7.00478 12 7.00478C13.1046 7.00478 14 7.90021 14 9.00478C14 10.1093 13.1046 11.0048 12 11.0048Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
