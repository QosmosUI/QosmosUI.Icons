// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Default;

public class MdScreenSearchDesktop : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "g");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "height", "1.8");
		builder.AddAttribute(18, "width", "4.8");
		builder.AddAttribute(19, "x", "9.6");
		builder.AddAttribute(20, "y", "16.8");
		builder.AddAttribute(21, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M20,18 C21.1,18 21.99,17.1 21.99,16 L22,6 C22,4.89 21.1,4 20,4 L4,4 C2.89,4 2,4.89 2,6 L2,16 C2,17.1 2.89,18 4,18 L0,18 L0,20 L24,20 L24,18 L20,18 Z M4,16 L4,6 L20,6 L20,16 L20,16.01 L4,16 Z M9.0967,9.9531 C9.0967,8.9261 9.9327,8.0891 10.9607,8.0891 C11.9877,8.0891 12.8247,8.9261 12.8247,9.9531 C12.8247,10.9801 11.9877,11.8171 10.9607,11.8171 C9.9327,11.8171 9.0967,10.9801 9.0967,9.9531 Z M16.1287,14.1891 L13.6467,11.7071 C13.9777,11.2021 14.1737,10.6001 14.1737,9.9531 C14.1737,8.1811 12.7327,6.7401 10.9607,6.7401 C9.1887,6.7401 7.7467,8.1811 7.7467,9.9531 C7.7467,11.7251 9.1887,13.1671 10.9607,13.1671 C11.5967,13.1671 12.1857,12.9751 12.6847,12.6561 L15.1737,15.1441 L16.1287,14.1891 Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "height", "24");
		builder.AddAttribute(26, "width", "24");
		builder.AddAttribute(27, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
