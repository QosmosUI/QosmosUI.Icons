// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrSquare : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M14.4444444,8.33333333 L9.55555556,8.33333333 C8.88088889,8.33333333 8.33333333,8.88088889 8.33333333,9.55555556 L8.33333333,14.4444444 C8.33333333,15.1191111 8.88088889,15.6666667 9.55555556,15.6666667 L14.4444444,15.6666667 C15.1191111,15.6666667 15.6666667,15.1191111 15.6666667,14.4444444 L15.6666667,9.55555556 C15.6666667,8.88088889 15.1191111,8.33333333 14.4444444,8.33333333 M18.1111111,22 L5.88888889,22 C3.74128475,22 2,20.2587153 2,18.1111111 L2,5.88888889 C2,3.74128475 3.74128475,2 5.88888889,2 L18.1111111,2 C20.2587153,2 22,3.74128475 22,5.88888889 L22,18.1111111 C22,20.2587153 20.2587153,22 18.1111111,22 L18.1111111,22 Z M18.1111111,24 C21.3632847,24 24,21.3632847 24,18.1111111 L24,5.88888889 C24,2.63671525 21.3632847,0 18.1111111,0 L5.88888889,0 C2.63671525,0 0,2.63671525 0,5.88888889 L0,18.1111111 C0,21.3632847 2.63671525,24 5.88888889,24 L18.1111111,24 L18.1111111,24 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
