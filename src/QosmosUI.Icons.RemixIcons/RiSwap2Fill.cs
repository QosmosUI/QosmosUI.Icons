// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiSwap2Fill : ComponentBase
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
		builder.AddAttribute(14, "d", "M17.2073 2.29291L15.793 3.70712L18.0859 6.00002H13.0002V8.00001H18.0859L15.793 10.2929L17.2073 11.7071L21.9144 7.00001L17.2073 2.29291ZM7.00015 11.5C9.48543 11.5 11.5002 9.4853 11.5002 7.00001C11.5002 4.51473 9.48543 2.50001 7.00015 2.50001C4.51487 2.50001 2.50015 4.51473 2.50015 7.00001C2.50015 9.4853 4.51487 11.5 7.00015 11.5ZM5.91436 18L8.20726 20.2929L6.79304 21.7071L2.08594 17L6.79304 12.2929L8.20726 13.7071L5.91436 16H11.0002V18H5.91436ZM14.0002 13C13.4479 13 13.0002 13.4477 13.0002 14V20C13.0002 20.5523 13.4479 21 14.0002 21H20.0002C20.5524 21 21.0002 20.5523 21.0002 20V14C21.0002 13.4477 20.5524 13 20.0002 13H14.0002Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
