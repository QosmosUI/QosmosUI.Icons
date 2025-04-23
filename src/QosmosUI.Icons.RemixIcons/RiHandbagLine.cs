// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiHandbagLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.0002 2C15.8662 2 19.0002 5.13401 19.0002 9H20.0742C20.5967 9 21.0311 9.40231 21.0712 9.9233L21.9174 20.9233C21.9597 21.474 21.5477 21.9547 20.997 21.9971L20.9203 22H3.08008C2.52779 22 2.08008 21.5523 2.08008 21L2.08302 20.9233L2.92918 9.9233C2.96925 9.40231 3.4037 9 3.92623 9H5.0002C5.0002 5.13401 8.13421 2 12.0002 2ZM19.1472 11H4.8522L4.1592 20H19.8402L19.1472 11ZM14.0002 13V15H10.0002V13H14.0002ZM12.0002 4C9.31145 4 7.11838 6.12231 7.00482 8.78311L7.0002 9H17.0002C17.0002 6.31124 14.8779 4.11818 12.2171 4.00462L12.0002 4Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
