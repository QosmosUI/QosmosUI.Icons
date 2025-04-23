// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiZhihuLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.3445 17.9633L10.6572 19.037L8.52534 15.687C8.0855 17.089 7.3539 18.3525 6.38696 19.5123C5.98479 19.9947 5.5676 20.4299 5.08571 20.8876C4.93103 21.0345 4.31113 21.604 4.20793 21.7072L2.79372 20.293C2.93256 20.1542 3.58085 19.5585 3.70848 19.4373C4.13828 19.0292 4.50381 18.6478 4.8508 18.2316C6.11713 16.7127 6.87997 15.0205 6.98764 13.0001H3.00082V11.0001H7.00082V7.00013H6.13284C5.44422 8.26619 4.57451 9.22211 3.51532 9.85763L2.48633 8.14264C3.88223 7.3051 4.91211 5.53959 5.52464 2.7832L7.47701 3.21706C7.33636 3.85 7.17352 4.44451 6.98811 5.00013H11.5008V7.00013H9.00082V11.0001H11.5008V13.0001H9.18613L12.3445 17.9633ZM16.1833 17.8929L17.2993 17.0001H19.0008V7.00013H15.0008V17.0001H15.7369L16.1833 17.8929ZM13.0008 5.00013H21.0008V19.0001H18.0008L15.5008 21.0001L14.5008 19.0001H13.0008V5.00013Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
