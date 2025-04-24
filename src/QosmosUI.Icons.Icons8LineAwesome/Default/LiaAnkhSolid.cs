// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaAnkhSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 16 2 C 13.25 2 11 4.25 11 7 C 11 8.957031 12.113281 10.875 13.15625 12.4375 C 13.289063 12.640625 13.429688 12.8125 13.5625 13 L 8 13 L 8 16.15625 L 9.15625 16 L 14.90625 15.1875 L 14 28.9375 L 13.9375 30 L 18.0625 30 L 18 28.9375 L 17.09375 15.1875 L 22.84375 16 L 24 16.15625 L 24 13 L 18.4375 13 C 18.570313 12.8125 18.710938 12.640625 18.84375 12.4375 C 19.886719 10.875 21 8.957031 21 7 C 21 4.25 18.75 2 16 2 Z M 16 4 C 17.667969 4 19 5.332031 19 7 C 19 8.078125 18.113281 9.914063 17.15625 11.34375 C 16.574219 12.21875 16.367188 12.429688 16 12.875 C 15.632813 12.429688 15.425781 12.21875 14.84375 11.34375 C 13.886719 9.914063 13 8.078125 13 7 C 13 5.332031 14.332031 4 16 4 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
