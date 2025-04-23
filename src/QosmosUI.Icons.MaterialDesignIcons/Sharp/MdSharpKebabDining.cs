// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpKebabDining : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M7.75,8H11v5H7.75v1H8.5c1.38,0,2.5,1.12,2.5,2.5S9.88,19,8.5,19H7.75v4h-1.5v-4H5.5C4.12,19,3,17.88,3,16.5S4.12,14,5.5,14 h0.75v-1H3V8h3.25V7H5.5C4.12,7,3,5.88,3,4.5S4.12,2,5.5,2h0.75V1h1.5v1H8.5C9.88,2,11,3.12,11,4.5S9.88,7,8.5,7H7.75V8z M17.75,7 h0.75C19.88,7,21,5.88,21,4.5S19.88,2,18.5,2h-0.75V1h-1.5v1H15.5C14.12,2,13,3.12,13,4.5S14.12,7,15.5,7h0.75v1H13v5h3.25v1H15.5 c-1.38,0-2.5,1.12-2.5,2.5s1.12,2.5,2.5,2.5h0.75v4h1.5v-4h0.75c1.38,0,2.5-1.12,2.5-2.5S19.88,14,18.5,14h-0.75v-1H21V8h-3.25V7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
